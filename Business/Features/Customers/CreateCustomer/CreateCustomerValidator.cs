using FluentValidation;

namespace Business.Features.Customers.CreateCustomer
{
    public sealed class CreateCustomerValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerValidator()
        {
            RuleFor(e => e.CustomerName).NotEmpty().WithMessage("İsim Boş olamaz");
            RuleFor(e => e.CustomerName).NotNull().WithMessage("İsim Boş olamaz");
            RuleFor(e => e.Lastname).NotEmpty().WithMessage("Soyisim Boş olamaz");
            RuleFor(e => e.Lastname).NotEmpty().WithMessage("Soyisim Boş olamaz");
            RuleFor(e => e.Phone).NotEmpty().WithMessage("Telefon Numarası Boş olamaz");
            RuleFor(e => e.Phone).NotNull().WithMessage("Telefon Numarası Boş olamaz");
            RuleFor(e => e.Email).NotEmpty().WithMessage("Email Boş olamaz");
            RuleFor(e => e.Email).NotNull().WithMessage("Email Boş olamaz");
            RuleFor(e => e.Address).NotEmpty().WithMessage("Adres Boş olamaz");
            RuleFor(e => e.Address).NotNull().WithMessage("Adres Boş olamaz");
        }
    }
}
