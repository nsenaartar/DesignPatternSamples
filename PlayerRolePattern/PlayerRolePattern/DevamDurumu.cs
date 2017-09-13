using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerRolePattern
{
    public abstract class DevamDurumu
    {
        public int devam;
        public abstract Boolean Devamsızmı();
    }
    public class FullTime : DevamDurumu
    {
        public override bool Devamsızmı()
        {
            if (devam > 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class PartTime : DevamDurumu
    {
        public override bool Devamsızmı()
        {
            return false;
        }
    }
}
