using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church_Timer
{
    public class enumtest
    {
        enum days { sun, mon, tue, wed, thur, fri, sat };
        static void main()
        {
        
        int x = (int) days.sun;
        int y = (int)days.fri;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri ={0}", y);
        }

    }
}
