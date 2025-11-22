using Sioat.Optimize;

using static Sioat.Benchmark.TestData;

namespace Sioat.Benchmark.Collections
{
    public class Dictionary_Foreach_Test
    {
        public static volatile int result;

        [Test("Dictionary Foreach")]
        [DontOptimize]
        public void Dict_Foreach()
        {
            int ct = 0;
            foreach (var pair in dict)
            {
                ct += pair.Value.no;
            }
            result = ct;
        }

        [Test("Dictionary Foreach (Optimize)")]
        public void Dict_Foreach_Optimized()
        {
            int ct = 0;
            foreach (var pair in dict)
            {
                ct += pair.Value.no;
            }
            result = ct;
        }

        //[Test("Dictionary Foreach X5")]
        //[DontOptimize]
        //public void Dict_Foreachx4()
        //{
        //    int ct = 0;
        //    foreach (var pair in dict)
        //    {
        //        ct += pair.Value.no + pair.Value.a0 + pair.Value.a1 + pair.Value.a10 + pair.Value.a3;
        //    }
        //    result = ct;
        //    if (CanPrint) Log("Dict " + ct);
        //}

        //[Test("Dictionary Foreach X5 Optimize")]
        //public void Dict_Foreachx4_Optimized()
        //{
        //    int ct = 0;
        //    foreach (var pair in dict)
        //    {
        //        ct += pair.Value.no + pair.Value.a0 + pair.Value.a1 + pair.Value.a10 + pair.Value.a3;
        //    }
        //    result = ct;
        //    if (CanPrint) Log("DictOp " + ct);
        //}
    }
}