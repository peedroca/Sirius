﻿using Sirius.CrossCutting.Email.Models;
using Sirius.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Service
{
    public class Settings
    {
        internal static SenderEmail SenderEmail;

        public Settings(string connectionString, SenderEmail senderEmail = null)
        {
            new ConnectionFactory(connectionString);
            SenderEmail = senderEmail;
        }

        public Settings(SenderEmail senderEmail)
        {
            SenderEmail = senderEmail;
        }
    }
}
