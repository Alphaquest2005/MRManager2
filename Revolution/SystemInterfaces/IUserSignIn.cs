using System.ComponentModel.Composition;

namespace SystemInterfaces
{
    [InheritedExport]
    public partial interface IUserSignIn :IUser, IEntity
    {
        string Username { get; }
        string Password { get; }

    }
}