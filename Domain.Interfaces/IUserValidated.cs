using SystemInterfaces;
using Interfaces;

namespace Domain.Interfaces
{
    public interface IUserValidated : IProcessSystemMessage
    {
        IUserSignIn UserSignIn { get; }
    }
}
