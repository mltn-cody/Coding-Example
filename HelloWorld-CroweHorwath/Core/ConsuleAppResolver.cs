using System;
using Ninject.Modules;

namespace HelloWorld_CroweHorwath
{
    public class ConsuleAppResolver : NinjectModule
    {
        public override void Load()
        {
            Kernel.Rebind<IWriter>().To<ConsoleWriter>();
            Kernel.Rebind<Writer>().To<ConsoleApp>();
        }
    }
}
