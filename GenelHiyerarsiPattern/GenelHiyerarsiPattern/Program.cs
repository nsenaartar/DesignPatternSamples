using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelHiyerarsiPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Calısan Ahmet = new Calısan();
            Ahmet.adı = "Ahmet";
            Calısan Mehmet = new Calısan();
            Mehmet.adı = "Mehmet";
            Yonetici Veli = new Yonetici();
            Veli.adı = "Veli";
            Veli.AddCalısan(Ahmet);
            Veli.AddCalısan(Mehmet);
            Console.WriteLine("Ahmetin Yöneticisi : " + Ahmet.yonetici.adı);
            Console.WriteLine("Mehmetin Yöneticisi : " + Mehmet.yonetici.adı);
            foreach (Calısan item in Veli.altlar)
            {
             Console.WriteLine(item.adı);
            }
            Console.Read();
        }
    }
}
