using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5sem_Lab1UDP
{
    internal class ConsoleDriver
    {
        TextBox console;
        public ConsoleDriver(TextBox console) 
        {
            this.console = console;
        }

        public void Log(string message)
        {
            console.Text = message + Environment.NewLine + console.Text;
        }

        public void Error(string message)
        {
            console.Text = "Err: "+message + Environment.NewLine + console.Text;
        }

    }
}
