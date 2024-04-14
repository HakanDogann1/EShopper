using Autofac;
using Autofac.Core;
using EShopper.BusinessLayer.Abstract;
using EShopper.BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.DependencyResolves.Autofac
{
    public class AutofacManager:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();
            builder.RegisterType<ColorRegisterManager>().As<IColorRegisterService>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
        }
    }
}
