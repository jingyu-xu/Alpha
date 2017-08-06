using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccessObject.Enums
{
    public enum StatusTypes
    {
        //Success and not need audit
        Success = 1000,

        //Success and need audit
        LogIn = 2000,

        //No Success and need audit
        IncorrectPassword = 3000,
        AccountLocked = 3001,

        //No Success and not need audit
        DateError = 4000,
        AuthorizationError = 4001,
        RegistrationInComplete = 4002,
        ExpiredToken = 4003
    }
}
