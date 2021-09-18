﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albert.Interface
{
    interface IAzure
    {
        void RunAzureDevOpsExtension(IServiceProvider sp, string[] args);
    }
}
