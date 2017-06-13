using Ninject;
using System;

namespace HelloWorld_CroweHorwath
{
    public sealed class KernalEngine {
        private static readonly Lazy<KernalEngine> instance = new Lazy<KernalEngine>(() => new KernalEngine());
        public IKernel GetKernal { get; }

        private KernalEngine() {
            GetKernal = new StandardKernel();
        }

        public static KernalEngine Instance {
            get { return instance.Value; }
        }
    }
}
