﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STEM_Application
{
    interface IUserService
    {

       User AddNewUser(User pUser);

       Boolean ValidateUser(User pUSer);

    }
}
