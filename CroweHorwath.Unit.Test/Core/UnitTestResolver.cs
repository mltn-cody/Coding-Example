using Ninject.Modules;
using HelloWorld_CroweHorwath;

namespace CroweHorwath.Unit.Test.Core
{
    public class UnitTestResolver : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IWriter>().To<MockWriter>();
            Kernel.Bind<Writer>().To<MockApp>();
        }
    }
}
