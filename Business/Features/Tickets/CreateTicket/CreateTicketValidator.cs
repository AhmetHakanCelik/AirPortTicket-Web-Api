using FluentValidation;

namespace Business.Features.Tickets.CreateTicket
{
    public class CreateTicketValidator:AbstractValidator<CreateTicketCommand>
    {
        public CreateTicketValidator()
        {
            RuleFor(e => e.CustomerFullName).NotEmpty().WithMessage("Ad alanı boş olamaz");
            RuleFor(e => e.CustomerFullName).NotNull().WithMessage("Kimlik numarası boş olamaz");
            RuleFor(e => e.Date).NotEmpty().WithMessage("Tarih boş olamaz");
            RuleFor(e => e.Date).NotNull().WithMessage("Tarih boş olamaz");
            RuleFor(e => e.Cost).GreaterThan(0).WithMessage("Ücret 0 dan büyük olmalı");
            RuleFor(e => e.CustomerFullName).MinimumLength(6).WithMessage("İsim-Soyisim en az 6 haneli olmalı");
        }
    }
}
