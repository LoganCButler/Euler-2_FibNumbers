using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AppLogic
    {
        public int answer;

        int topNumber = 4000000;
        bool underTopNumber = true;

        public int getEvenFibNumbers()
        {
            int a = 1;
            int b = 2;
            int sum = 0;
            while (underTopNumber)
            {
                if (b > topNumber)
                {
                    underTopNumber = false;
                }
                else if (b%2 == 0)
                {
                    sum += b;
                }
                int aTemp = a;

                a = b;
                b += aTemp;
            }
            answer = sum;
            return answer;
        }
    }
}
