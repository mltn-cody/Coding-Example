using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_CroweHorwath
{
    class ConsoleWriter : IWriter
    {
        public void Write(dynamic @object)
        {
            Console.Write(@object);
        }
    }
}
