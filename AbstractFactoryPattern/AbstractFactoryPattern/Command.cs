using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class Command
    {
        public abstract void Execute(string query);
    }
    public class SQLCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("SQLCommand Execute Metodu Çalıştı.");
        }
    }
    public class InterBaseCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("InterBaseCommand Execute Metodu Çalıştı.");
        }
    }
}
