using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    class PCSClass
    {

        Students[] student;
        float[] attention;

        public String studentRank(float tMark, float eMark)
        {

            String result = "";
            if (tMark < 40 && eMark < 40)
            {
                result = " Fail";
            }
            else if (tMark < 40 && eMark >= 40)
            {
                result = "The theory fail";
            }
            else if (tMark >= 40 && eMark < 40)
            {
                result = "The pactice fail";
            }
            else
            {
                result = "Pass";
            }

            return result;


        }
    }
}
