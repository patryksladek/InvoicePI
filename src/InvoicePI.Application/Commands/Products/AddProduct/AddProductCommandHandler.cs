using InvoicePI.Application.Dto;
using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Products;
using InvoicePI.Domain.Enums;
using InvoicePI.Domain.Exceptions;
using MediatR;

namespace InvoicePI.Application.Commands.Products.AddProduct;

internal class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductDetailDto>
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ProductDetailDto> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        bool isAlreadyExistWithSameName = await _productRepository.IsAlreadyExistWithSameNameAsync(request.Name, cancellationToken);
        if (isAlreadyExistWithSameName)
            throw new ProductWithSameNameAlreadyExistsException(request.Name);

        if (!request.Code.Equals("?")) 
        { 
            bool isAlreadyExistWithSameCode =  await _productRepository.IsAlreadyExistWithSameCodeAsync(request.Code, cancellationToken);
            if (isAlreadyExistWithSameCode)
                throw new ProductWithSameCodeAlreadyExistsException(request.Code);
        }

        string productCode = request.Code.Equals("?") ? await _productRepository.GetNextProductCodeAsync() : request.Code;

        var newProduct = new Product()
        {
            Name = request.Name,
            Code = productCode,
            Type = (ProductType)request.ProductType,
            Barcode = request.Barcode,
            BarcodeType = (ProductBarcodeType)request.ProductBarcodeType,
            CurrencyId = request.CurrencyId,
            UnitId = request.UnitId,
            VatRateId = request.VatRateId,
            NetPrice = request.Price
        };

        _productRepository.Add(newProduct);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var productDto = new ProductDetailDto()
        {
            Id = newProduct.Id,
            Name = newProduct.Name,
            Code = newProduct.Code,
            ProductType = newProduct.Type.ToString(),
            Barcode = newProduct.Barcode,
            ProductBarcodeType = newProduct.BarcodeType.ToString(),
            CurrencyId = newProduct.CurrencyId,
            UnitId = newProduct.UnitId,
            VatRateId= newProduct.VatRateId,
            Price = newProduct.NetPrice
        };

        return productDto;
    }
}
