﻿using SAEA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SAEA.DistributedServices.Host
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            DistributedHelper.TansactionServiceInit();


            Console.ReadLine();
        }


        
    }
}