﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccessObject.Requests
{
    public interface ISecureRequest 
    {
        UserContext UserContext { get; set; }
    }
}
