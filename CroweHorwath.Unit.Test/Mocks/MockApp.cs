using System;
using System.Threading.Tasks;
using HelloWorld_CroweHorwath;
using System.Threading;

namespace CroweHorwath.Unit.Test
{
    public class MockApp : Writer
    {
        public MockApp(IWriter write) : base(write)
        { }

        public override async Task<string> Write(dynamic @object)
        {
            return await Task.Run(async () =>
            {
                // do some stuff
                 await Task.Delay(1000);
                //
                return "Success";
            });
           
        }
    }
}