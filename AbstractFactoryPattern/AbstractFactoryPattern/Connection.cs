using AbstractFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class Connection
    {
        public abstract void Connect();
        public abstract void Disconnect();
        public abstract string State
        {
            get;
        }
    }
    public class SQLConnection : Connection
    {
        public override string State
        {
            get { return "SQLConnection Bağlantı Durumu"; }
        }
        public override void Connect()
        {
            Console.WriteLine("SQLConnection Connect Metodu Çalıştı.");
        }
        public override void Disconnect()
        {
            Console.WriteLine("SQLConnection Disconnect Metodu Çalıştı.");
        }
    }
    public class InterBaseConnection : Connection
    {
        public override string State
        {
            get { return "InterBaseConnection Bağlantı Durumu"; }
        }
        public override void Connect()
        {
            Console.WriteLine("InterBaseConnection Connect Metodu Çalıştı.");
        }
        public override void Disconnect()
        {
            Console.WriteLine("InterBaseConnection Disconnect Metodu Çalıştı.");
        }
    }
}