using FluentValidation;

namespace Business.Features.Bills.CreateBill
{
    internal class CreateBillValidator:AbstractValidator<CreateBillCommand>
    {
        public CreateBillValidator() 
        { 
            RuleFor(e => e.Identification_Number).NotEmpty().WithMessage("Kimlik numarası boş olamaz");
            RuleFor(e => e.Identification_Number).NotNull().WithMessage("Kimlik numarası boş olamaz");
            RuleFor(e => e.CustomerName).NotEmpty().WithMessage("Ad alanı boş olamaz");
            RuleFor(e => e.CustomerName).NotNull().WithMessage("Ad alanı boş olamaz");
            RuleFor(e => e.CustomerLastName).NotEmpty().WithMessage("soyad alanı boş olamaz");
            RuleFor(e => e.CustomerLastName).NotNull().WithMessage("Soyad alanı boş olamaz");
            RuleFor(e => e.CustomerName).MinimumLength(3).WithMessage("İsim en az 3 haneli olmalı");
            RuleFor(e => e.CustomerLastName).MinimumLength(3).WithMessage("soyisim en az 3 haneli olmalı");
        }    
    }
}
