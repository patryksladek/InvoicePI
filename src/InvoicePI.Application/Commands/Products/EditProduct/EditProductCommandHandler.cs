using InvoicePI.Application.Commands.Customers.AddCustomer;
using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities;
using InvoicePI.Domain.Entities.Definitions;
using InvoicePI.Domain.Entities.Products;
using InvoicePI.Domain.Enums;
using InvoicePI.Domain.Exceptions;
using MediatR;
using System.Diagnostics;

namespace InvoicePI.Application.Commands.Customers.EditCusotmer;

internal class EditProductCommandHandler : IRequestHandler<EditProductCommand>
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;

    public EditProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(EditProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(request.Id, cancellationToken);
        if (product == null)
            throw new ProductNotFoundException(request.Id);

        bool isAlreadyExistWithSameName = await _productRepository.IsAlreadyExistWithSameNameAsync(request.Id, request.Name, cancellationToken);
        if (isAlreadyExistWithSameName)
            throw new ProductWithSameNameAlreadyExistsException(request.Name);

        if (!request.Code.Equals("?"))
        {
            bool isAlreadyExistWithSameCode = await _productRepository.IsAlreadyExistWithSameCodeAsync(request.Id, request.Code, cancellationToken);
            if (isAlreadyExistWithSameCode)
                throw new ProductWithSameCodeAlreadyExistsException(request.Code);
        }

        product.Name = request.Name;
        product.Code = request.Code;
        product.Code = request.Code;
        product.Type = (ProductType)request.ProductType;
        product.Barcode = request.Barcode;
        product.BarcodeType = (ProductBarcodeType)request.ProductBarcodeType;
        product.CurrencyId = request.CurrencyId;
        product.UnitId = request.UnitId;
        product.VatRateId = request.VatRateId;
        product.NetPrice = request.Price;

        _productRepository.Update(product);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
