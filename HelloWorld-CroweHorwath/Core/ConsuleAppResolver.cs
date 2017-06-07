using System;
using Ninject.Modules;

namespace HelloWorld_CroweHorwath
{
    public class ConsuleAppResolver : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IWriter>().To<ConsoleWriter>();
            Kernel.Bind<Writer>().To<ConsoleApp>();
        }
    }
}
