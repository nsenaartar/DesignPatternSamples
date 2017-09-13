using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton _ınstance;
        private static Guid _id;

        private Singleton(Guid id)
        {
            _id = id;
        }
        public Guid Id()
        {
             return Singleton._id; 
        }
       public static Singleton GetInstance()
        {
            if (_ınstance == null)
            {
                _ınstance = new Singleton(Guid.NewGuid());
            }
            return _ınstance;
        }





    }
}
