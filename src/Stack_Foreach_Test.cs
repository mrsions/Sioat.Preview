using System;
using System.Collections.Generic;

using Sioat.Optimize;

using static Sioat.Benchmark.TestData;

namespace Sioat.Benchmark.Collections
{
    public class Stack_Foreach_Test
    {
        public static volatile int result;

        [Test("Stack Foreach")]
        [DontOptimize]
        public void Stack_Foreach()
        {
            int ct = 0;
            foreach (var player in stack)
            {
                ct += player.no;
            }
            result = ct;
        }

        [Test("Stack Foreach (Optimize)")]
        public void Stack_Foreach_Optimized()
        {
            int ct = 0;
            foreach (var player in stack)
            {
                ct += player.no;
            }
            result = ct;
        }

        //[Test("Stack Foreach X5")]
        //[DontOptimize]
        //public void Stack_Foreach_X5()
        //{
        //    int ct = 0;
        //    foreach (var player in stack)
        //    {
        //        ct += player.no + player.a0 + player.a1 + player.a10 + player.a3;
        //    }
        //    result = ct;
        //    if (CanPrint) Log("Stack X5 " + ct);
        //}

        //[Test("Stack Foreach X5 Optimized")]
        //public void Stack_Foreach_X5_Optimized()
        //{
        //    int ct = 0;
        //    foreach (var player in stack)
        //    {
        //        ct += player.no + player.a0 + player.a1 + player.a10 + player.a3;
        //    }
        //    result = ct;
        //    if (CanPrint) Log("Stack X5 Optimized " + ct);
        //}
    }
}
