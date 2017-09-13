using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
    public class SQLDatabase : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new SQLCommand();
        }

        public override Connection CreateConnection()
        {
            return new SQLConnection();
        }
    }
    public class InterBaseDB : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new InterBaseCommand();
        }
        public override Connection CreateConnection()
        {
            return new InterBaseConnection();
        }
    }
}
