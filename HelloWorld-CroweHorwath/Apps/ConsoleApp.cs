using System.Threading.Tasks;
using System;

namespace HelloWorld_CroweHorwath
{
    public class ConsoleApp : Writer
    {
        public ConsoleApp(IWriter write) 
            : base(write)
        {
        }

        public override Task<string> Write(dynamic @object)
        {
            if (@object == null) throw new ArgumentNullException(nameof(@object));
            return Task.Run(() =>
            {
                _writer.Write(@object);
                return "Success";
            });

        }
    }

}
