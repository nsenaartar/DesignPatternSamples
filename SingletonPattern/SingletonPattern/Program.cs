using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton singleton1 = new Singleton();
            Singleton sinleton1 = Singleton.GetInstance();
            Console.WriteLine(sinleton1.Id().ToString());
            Singleton sinleton2 = Singleton.GetInstance();
            Console.WriteLine(sinleton2.Id().ToString());
            Console.Read();
        }
    }
}
