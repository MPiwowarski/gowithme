using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithMe.View
{
    public interface IRegistrationForm
    {
        string Email { get; }
        string Login { get; }
        string Password { get; }
        string Name { get; }
        string Surname { get; }
        string PhoneNumber { get; }
        DateTime RegistrationDate { get; }

    }
}
