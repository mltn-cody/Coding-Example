using System.Threading.Tasks;

namespace HelloWorld_CroweHorwath
{
    public abstract class Writer {

        protected IWriter _writer;

        public Writer(IWriter write) {
            _writer = write;
        }

        public abstract Task<string> Write(dynamic @object);
    }

}
