using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trying_Stuff_Outski.Extension_Methods
{
    public static class List_Extensions
    {
        public static List<int> TakeEverySecond(this List<int> inputs)
        {
            var result = new List<int>();
            int index = 0;
            foreach (var input in inputs)
            {
                if (index % 2 == 0)
                {
                    result.Add(input);
                   
                }
                index++;
            }
            return result;
        }
    }
}
