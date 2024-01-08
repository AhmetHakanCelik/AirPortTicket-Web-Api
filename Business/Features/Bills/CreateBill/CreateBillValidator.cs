using FluentValidation;

namespace Business.Features.Bills.CreateBill
{
    public class CreateBillValidator:AbstractValidator<CreateBillCommand>
    {
        public CreateBillValidator() 
        { 
            RuleFor(e => e.Identification_Number).GreaterThan(9999).WithMessage("Kimlik numarası en az 5 haneli olmalıdır");
            RuleFor(e => e.CustomerName).NotEmpty().WithMessage("Ad alanı boş olamaz");
            RuleFor(e => e.CustomerName).NotNull().WithMessage("Ad alanı boş olamaz");
            RuleFor(e => e.CustomerLastName).NotEmpty().WithMessage("soyad alanı boş olamaz");
            RuleFor(e => e.CustomerLastName).NotNull().WithMessage("Soyad alanı boş olamaz");
            RuleFor(e => e.CustomerName).MinimumLength(3).WithMessage("İsim en az 3 haneli olmalı");
            RuleFor(e => e.CustomerLastName).MinimumLength(3).WithMessage("soyisim en az 3 haneli olmalı");
        }    
    }
}
