using Ninject;

namespace HelloWorld_CroweHorwath
{
    public sealed class KernalEngine {
        private static KernalEngine instance;
        public IKernel GetKernal { get; }

        private KernalEngine() {
            GetKernal = new StandardKernel();
        }

        static KernalEngine() {
            instance = new KernalEngine();
        }

        public static KernalEngine Instance {
            get { return instance; }
        }
    }
}
