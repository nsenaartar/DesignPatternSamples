using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerRolePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ali = new Ogrenci();
            ali.devamRolu = new FullTime();
            ali.devamRolu.devam = 150;
            Console.Write("Ali devamsızlıktan kaldı mı?" + ali.devamRolu.Devamsızmı());

            ali.notOrtamalası = 3.00;
            ali.egitimSeviye = new Lisans();
            Console.Write("Ali mezun olabilir mi?"+ali.egitimSeviye.mezuniyet((int)ali.notOrtamalası));
            
            Console.Read();
        }
    }
}
