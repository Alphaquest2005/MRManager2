﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInterfaces;
using CommonMessages;
using Domain.Interfaces;
using Interfaces;

namespace DomainMessages
{
    public class UserValidated : ProcessSystemMessage, IUserValidated
    {
        public UserValidated(IUserSignIn userSignIn, IProcessStateInfo processInfo, ISystemProcess process, ISystemSource source) : base(processInfo,process, source)
        {
            UserSignIn = userSignIn;
        }

        public IUserSignIn UserSignIn { get; }
    }
}
