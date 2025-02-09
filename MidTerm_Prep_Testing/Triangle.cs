using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Prep_Testing
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            string result;

            if((firstAngle+secondAngle+thirdAngle) == 180)
            {
                result = "This triangle is valid";
            }
            else
            {
                result = "This triangle is NOT valid";
            }

            return result;
        }
    }
}
