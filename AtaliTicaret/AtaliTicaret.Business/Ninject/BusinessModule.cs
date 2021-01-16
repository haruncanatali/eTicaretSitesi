using AtaliTicaret.Business.Abstract;
using AtaliTicaret.Business.Concreate;
using AtaliTicaret.DataAccess.Abstract;
using AtaliTicaret.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.Business.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            //DesktopUI için dependecy injection

            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<ProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<CategoryDal>().InSingletonScope();

            Bind<IDealerService>().To<DealerManager>().InSingletonScope();
            Bind<IDealerDal>().To<DealerDal>().InSingletonScope();
        }
    }
}
