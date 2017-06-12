using Ninject;
using System;
using System.Configuration;

namespace HelloWorld_CroweHorwath.Creator
{
    public class ConfigurationAppCreater : AppCreator
    {
        public override Writer CreateWriter()
        {
            var selection = ConfigurationManager.AppSettings["UseWriter"];
            switch (selection) {
                case "Console":
                    var kernel = new StandardKernel();
                    kernel.Load<ConsuleAppResolver>();
                    var writer = kernel.Get<Writer>();
                    return writer;
                default:
                    throw new Exception("App Not Avaiable");
            };
        }
    }
}
