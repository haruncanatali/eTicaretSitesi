﻿using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.Business.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
