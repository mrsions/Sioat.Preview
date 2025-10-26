using System.Collections.Generic;

using SIOAT.Optimize;

using UnityEngine.Assertions;

using static SIOAT.Test.TestData;

namespace SIOAT.Test
{
    public class Foreach_Full_Optimize_Fast
    {
        public static volatile int result;

        [Test("List Foreach")]
        public void List_Foreach()
        {
            int ct = 0;
            foreach (var player in list)
            {
                ct += player.no;
            }
            result = ct;
        }


        [Test("List Foreach (Fast)")]
        public void List_Foreach_Fast()
        {
            int ct = 0;
            foreach (var player in list._Fast())
            {
                ct += player.no;
            }
            result = ct;
        }

        [Test("List Foreach (Ref)")]
        public void List_Foreach_Ref()
        {
            int ct = 0;
            foreach (ref var player in list._Ref())
            {
                ct += player.no;
            }
            result = ct;
        }

        [Test("List Foreach (Ref+Fast)")]
        public void List_Foreach_RefFast()
        {
            int ct = 0;
            foreach (ref var player in list._Fast()._Ref())
            {
                ct += player.no;
            }
            result = ct;
        }
    }
}