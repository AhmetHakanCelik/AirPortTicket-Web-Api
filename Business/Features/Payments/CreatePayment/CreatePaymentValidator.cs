using FluentValidation;

namespace Business.Features.Payments.CreatePayment
{
    public class CreatePaymentValidator:AbstractValidator<CreatePaymentCommand>
    {
        public CreatePaymentValidator()
        {
            RuleFor(e => e.CardNumber).GreaterThan(1000).WithMessage("Kart numarası en az 4 haneli olmalı");
            RuleFor(e => e.SecurityCode).GreaterThanOrEqualTo(1000).WithMessage("Güvenlik kodu en az 4 haneli olmalı");
            RuleFor(e => e.FullName).NotEmpty().WithMessage("Ad alanı boş olamaz");
            RuleFor(e => e.FullName).NotNull().WithMessage("Ad alanı boş olamaz");
            RuleFor(e => e.FullName).MinimumLength(6).WithMessage("İsim en az 6 haneli olmalı");
        }
    }
}
