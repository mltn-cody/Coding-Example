using Ninject.Modules;
using HelloWorld_CroweHorwath.Creator;

namespace HelloWorld_CroweHorwath
{
    public class CreationResolver : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<AppCreator>().To<ConfigurationAppCreater>();
        }
    }
}
