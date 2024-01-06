using FluentValidation;

namespace Business.Features.Customers.CreateCustomer
{
    internal sealed class CreateCustomerValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerValidator()
        {
            RuleFor(e => e.CustomerName).NotEmpty().WithMessage("İsim Boş olamaz");
            RuleFor(e => e.CustomerName).NotNull().WithMessage("İsim Boş olamaz");
            RuleFor(e => e.Lastname).NotEmpty().WithMessage("Soyisim Boş olamaz");
            RuleFor(e => e.Lastname).NotEmpty().WithMessage("Soyisim Boş olamaz");
            RuleFor(e => e.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası Boş olamaz");
            RuleFor(e => e.PhoneNumber).NotNull().WithMessage("Telefon Numarası Boş olamaz");
            RuleFor(e => e.PhoneNumber).MinimumLength(10).WithMessage("Telefon Numarası 10 Haneli olmalıdır");
            RuleFor(e => e.PhoneNumber).MaximumLength(10).WithMessage("Telefon Numarası 10 Haneli olmalıdır");
            RuleFor(e => e.Email).NotEmpty().WithMessage("Email Boş olamaz");
            RuleFor(e => e.Email).NotNull().WithMessage("Email Boş olamaz");
            RuleFor(e => e.Address).NotEmpty().WithMessage("Adres Boş olamaz");
            RuleFor(e => e.Address).NotNull().WithMessage("Adres Boş olamaz");
        }
    }
}
