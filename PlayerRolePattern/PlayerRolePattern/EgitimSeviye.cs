using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerRolePattern
{
    public abstract class EgitimSeviye
    {
        public abstract Boolean mezuniyet(int not);
    }
    public class Lisans : EgitimSeviye
    {
        public override bool mezuniyet(int not)
        {
            if (not>2)
            {
                return true;
            }
            return false;
        }
    }
    public class LisansUstu : EgitimSeviye
    {
        public override bool mezuniyet(int not)
        {
            if (not > 3)
            {
                return true;
            }
            return false;
        }
    }
}
