using System;
using System.Collections.Generic;

namespace _13thAgeBuilder {
    class Calculations {
        public static int MiddleMod(int stat1, int stat2, int stat3) {
            int modStat1 = Convert.ToInt32(Math.Floor(((float)stat1 - 10) / 2));
            int modStat2 = Convert.ToInt32(Math.Floor(((float)stat2 - 10) / 2));
            int modStat3 = Convert.ToInt32(Math.Floor(((float)stat3 - 10) / 2));

            List<int> list = new List<int>();
            list.Add(modStat1);
            list.Add(modStat2);
            list.Add(modStat3);
            list.Sort();
            return list[1];
        }
    }
}
