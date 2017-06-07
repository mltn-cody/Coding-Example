using System;
using HelloWorld_CroweHorwath;

namespace CroweHorwath.Unit.Test
{
    public class MockWriter : IWriter
    {
        public void Write(dynamic @object)
        {
            throw new NotImplementedException();
        }
    }
}