using Ninject;
using NUnit.Framework;
using System.Reflection;

namespace CroweHorwath.Unit.Test
{
    [SetUpFixture]
    public class BaseTest
    {
        protected IKernel Kernerl { get; set; }

        [OneTimeSetUp]
        public void Init() {
            Kernerl = new StandardKernel();
            Kernerl.Load(Assembly.GetExecutingAssembly());
        }
    }
}