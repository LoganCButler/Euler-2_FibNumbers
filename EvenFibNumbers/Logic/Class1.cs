using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AppLogic
    {
        public int answer = 0;

        public int topNumberDefault = 4000000; // set by rules of the problem
        bool underTopNumber = true;

        public int getEvenFibNumbers(int topNumber)
        {
            int a = 1;
            int b = 2;
            while (underTopNumber)
            {
                if (b > topNumber)
                {
                    underTopNumber = false;
                }
                else if (b%2 == 0)
                {
                    answer += b;
                }
                int aTemp = a;

                a = b;
                b += aTemp;
            }
            return answer;
        }
    }
}
