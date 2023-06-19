using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.ViewModels.Products;
using FluentValidation;

namespace E_Ticaret.Application.Validators.Products
{
    public class CreateProductValidator:AbstractValidator<VM_Product_Create>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Ürün adı boş olmamalı")
            .NotNull().WithMessage("Ürün adı girdiğinize emin olunuz")
            .MinimumLength(3).WithMessage("Ürün adı minimum 3 karakter olmalıdır")
            .MaximumLength(20).WithMessage("Ürün adı maximum 20 karater olmalıdır");

            RuleFor(x => x.CategoryId)
            .NotEmpty().WithMessage("Ürün kategorisi seçilmelidir")
            .NotNull().WithMessage("Ürün kategorisi seçtiğinize emin olunuz")
            .GreaterThan(0).WithMessage("Ürün kategorisinin id numarası 0'dan büyük olmalıdr");

            RuleFor(x => x.Price)
            .NotEmpty().WithMessage("Ürün fiyatı girmelisiniz")
            .NotNull().WithMessage("Ürün fiyatı girdiğinize emin olunuz")
            .GreaterThanOrEqualTo(0).WithMessage("Ürün fiyat 0 veya 0'dan büyük olmalıdır.");

            RuleFor(x => (int)x.UnitsInStock)
            .NotEmpty().WithMessage("Ürün stok bilgisi girmelisiniz")
            .NotNull().WithMessage("Ürün stok bilgisi girdiğinize emin olunuz")
            .GreaterThanOrEqualTo(0).WithMessage("Ürün stok bilgisi 0 veya 0'dan büyük olmalıdır.");
        }
    }
}