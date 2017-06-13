using HelloWorld_CroweHorwath.Creator;
using Ninject;
using System;
using System.Reflection;

namespace HelloWorld_CroweHorwath
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel =  KernalEngine.Instance.GetKernal;
            kernel.Load<CreationResolver>();
            var creator = kernel.Get<AppCreator>();
            var writer = creator.CreateWriter();

            writer.Write("Hello World!");

            Console.ReadLine();
        }
    }
}
