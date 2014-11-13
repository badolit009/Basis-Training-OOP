using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    public static class PrimetiveExt
    {
        public static string GetFirstTwoCharacter(this string astring )
        {
            return astring.ToCharArray(0, 2).ToString();
        }

        public static bool IsBiggarThen100(this int aint)
        {
            if (aint>100)
            {
                return true; 
            }
            else
            {
                return false;
            }
            
        }
    }
}
