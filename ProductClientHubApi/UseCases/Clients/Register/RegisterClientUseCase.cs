using ProjectClientHub.Communication.Requests;
using ProjectClientHub.Communication.Responses;

namespace ProductClientHubApi.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {
        public ResponseClientJson Execute(RequestClientJson request)
        {
            var validator = new RegisterClientValidator();

            var result = validator.Validate(request);

            return new ResponseClientJson();
        }
    }
}
