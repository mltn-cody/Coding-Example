﻿using System.Threading.Tasks;
using System;

//a.The program has 1 current business requirement – write “Hello World” to the

//console/screen.

//b.The program should have an API that is separated from the program logic to eventually

//support mobile applications, web applications, or console applications, or windows

//services.

//c.The program should support future enhancements for writing to a database, console

//application, etc.

//i.Use common design patterns(inheritance, e.g.) to account for these future

//concerns.

//ii.Use configuration files or another industry-standard mechanism for determining

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
