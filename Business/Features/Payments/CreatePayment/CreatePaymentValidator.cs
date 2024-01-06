using FluentValidation;

namespace Business.Features.Payments.CreatePayment
{
    internal class CreatePaymentValidator:AbstractValidator<CreatePaymentCommand>
    {
        public CreatePaymentValidator()
        {
            RuleFor(e => e.CardNumber).NotEmpty().WithMessage("Kimlik numarası boş olamaz");
            RuleFor(e => e.CardNumber).NotNull().WithMessage("Kimlik numarası boş olamaz");
            RuleFor(e => e.SecurityCode).NotEmpty().WithMessage("Kimlik numarası boş olamaz");
            RuleFor(e => e.SecurityCode).NotNull().WithMessage("Kimlik numarası boş olamaz");
            RuleFor(e => e.SecurityCode).GreaterThanOrEqualTo(100).WithMessage("Güvenlik kodu en az 3 haneli olmalı");
            RuleFor(e => e.FullName).NotEmpty().WithMessage("Ad alanı boş olamaz");
            RuleFor(e => e.FullName).NotNull().WithMessage("Ad alanı boş olamaz");
            RuleFor(e => e.FullName).MinimumLength(6).WithMessage("İsim en az 6 haneli olmalı");
        }
    }
}
