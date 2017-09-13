using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelHiyerarsiPattern
{
    public class Yonetici : Calısan
    {
       public ArrayList  altlar= new ArrayList();
       public void AddCalısan(Calısan alt)
       {
            altlar.Add(alt);
            alt.yonetici = this;
       }
    }
}
