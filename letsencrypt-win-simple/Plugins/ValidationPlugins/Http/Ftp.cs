﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsEncrypt.ACME.Simple.Plugins.ValidationPlugins.Http
{
    class Ftp : HttpValidation
    {
        public override string Name
        {
            get
            {
                return "Http-Ftp";
            }
        }
    }
}