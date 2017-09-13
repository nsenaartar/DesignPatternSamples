using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(new SQLDatabase());
            factory.Start();
            //SQLConnection sqlCon = new SQLConnection();
            //sqlCon.Connect();
            //sqlCon.Disconnect();
            //SQLCommand sqlCom = new SQLCommand();
            //sqlCom.Execute("String Değer");
            Console.WriteLine("-------------");
            Factory factory2 = new Factory(new InterBaseDB());
            factory2.Start();
            //InterBaseConnection ınterBaseCon = new InterBaseConnection();
            //ınterBaseCon.Connect();
            //ınterBaseCon.Disconnect();
            //InterBaseCommand ınterBaseCom = new InterBaseCommand();
            //ınterBaseCom.Execute("String Değer");
            Console.WriteLine("-------------");
            Console.Read();
        }
    }
}
