using SystemInterfaces;
using Common.DataEntites;

namespace GenSoft.Entities
{
    public class UserSignIn: BaseEntity, IUserSignIn
    {
        public string UserId => Username;
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
    }
}