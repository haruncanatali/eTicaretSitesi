using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtaliTicaret.WebUI.Models
{
    public static class Sepet
    {

        public static Dictionary<int, int> Ids = new Dictionary<int, int>();

        public static void AddId(int id)
        {
            if (Ids.ContainsKey(id))
            {
                Ids[id] += 1;
            }
            else
            {
                Ids.Add(id, 1);
            }
        }

        public static int ShowSumOfValues()
        {
            return Ids.Values.Sum();
        }


    }
}
