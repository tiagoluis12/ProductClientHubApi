using FluentValidation;
using ProjectClientHub.Communication.Requests;

namespace ProductClientHubApi.UseCases.Clients.Register
{
    public class RegisterClientValidator : AbstractValidator<RequestClientJson>
    {
        public RegisterClientValidator()
        {
            RuleFor(client => client.Name).NotEmpty().WithMessage("O nome nao pode ser vazio");
            RuleFor(client => client.Email).EmailAddress().WithMessage("O email nao pode ser vazio.");
        }
    }
}
