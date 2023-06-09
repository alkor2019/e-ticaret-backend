using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.ViewModels.Products;
using FluentValidation;

namespace E_Ticaret.Application.Validators.Products
{
    public class CreateProductValidator: AbstractValidator<VM_Product_Create>
    {
        public CreateProductValidator()
        {
            RuleFor(x =>x.Name)
            .NotEmpty().WithMessage("Lütfen ürün adını giriniz")
            .NotNull().WithMessage("Lütfen ürün adını girdiğinizden emin olunuz")
            .MinimumLength(3).WithMessage("Ürün adı minimum 3 karakterden oluşmalıdır.")
            .MaximumLength(150).WithMessage("Ürün adı maximum 150 karakter içermelidir");

            RuleFor(x =>x.CategoryId)
            .NotEmpty().WithMessage("Lütfen bir kategori seçiniz")
            .NotNull().WithMessage("Lütfen ürün adını girdiğinizden emin olunuz")
            .GreaterThan(0).WithMessage("Lütfen geçerli bir kategori seçiniz");

            RuleFor(x =>x.Price)
            .NotEmpty().WithMessage("Lütfen ürün fiyatını giriniz")
            .NotNull().WithMessage("Lütfen ürün fiyatını girdiğinizden emin olunuz")
            .GreaterThanOrEqualTo(0).WithMessage("Fiyat bilgisi 0 veya 0'dan büyük bir değer olmalıdır");

            RuleFor(x =>x.UnitsInStock)
            .NotEmpty().WithMessage("Lütfen ürün stok adedini giriniz")
            .NotNull().WithMessage("Lütfen ürün stok adedini girdiğinizden emin olunuz")
            .GreaterThanOrEqualTo(0).WithMessage("Stok adedi 0 veya 0'dan büyük bir değer olmalıdır");
        }
    }
}