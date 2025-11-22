using Sioat.Optimize;

using static Sioat.Benchmark.TestData;

namespace Sioat.Benchmark.Collections
{
    public class HashSet_Foreach_Test
    {
        public static volatile int result;

        [Test("HashSet Foreach")]
        [DontOptimize]
        public void HashSet_Foreach()
        {
            int ct = 0;
            foreach (var player in hashSet)
            {
                ct += player.no;
            }
            result = ct;
        }

        [Test("HashSet Foreach (Optimize)")]
        public void HashSet_Foreach_Optimized()
        {
            int ct = 0;
            foreach (var player in hashSet)
            {
                ct += player.no;
            }
            result = ct;
        }

        //[Test("HashSet Foreach X5")]
        //[DontOptimize]
        //public void HashSet_Foreach_X5()
        //{
        //    int ct = 0;
        //    foreach (var player in hashSet)
        //    {
        //        ct += player.no + player.a0 + player.a1 + player.a10 + player.a3;
        //    }
        //    result = ct;
        //    if (CanPrint) Log("HashSet X5 " + ct);
        //}

        //[Test("HashSet Foreach X5 Optimized")]
        //public void HashSet_Foreach_X5_Optimized()
        //{
        //    int ct = 0;
        //    foreach (var player in hashSet)
        //    {
        //        ct += player.no + player.a0 + player.a1 + player.a10 + player.a3;
        //    }
        //    result = ct;
        //    if (CanPrint) Log("HashSet X5 Optimized " + ct);
        //}
    }
}
