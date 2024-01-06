using FluentValidation;

namespace Business.Features.Tickets.CreateTicket
{
    internal class CreateTicketValidator:AbstractValidator<CreateTicketCommand>
    {
        public CreateTicketValidator()
        {
            RuleFor(e => e.CustomerFullName).NotEmpty().WithMessage("Kimlik numarası boş olamaz");
            RuleFor(e => e.CustomerFullName).NotNull().WithMessage("Kimlik numarası boş olamaz");
            RuleFor(e => e.Date).NotEmpty().WithMessage("Kimlik numarası boş olamaz");
            RuleFor(e => e.Date).NotNull().WithMessage("Kimlik numarası boş olamaz");
            RuleFor(e => e.Cost).NotEmpty().WithMessage("Ad alanı boş olamaz");
            RuleFor(e => e.Cost).NotNull().WithMessage("Ad alanı boş olamaz");
            RuleFor(e => e.CustomerFullName).MinimumLength(6).WithMessage("İsim-Soyisim en az 6 haneli olmalı");
        }
    }
}
