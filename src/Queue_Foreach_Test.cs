using System;
using System.Collections.Generic;

using Sioat.Optimize;
using UnityEngine.Scripting;
using static Sioat.Benchmark.TestData;

namespace Sioat.Benchmark.Collections
{
    [Preserve]
    public class Queue_Foreach_Test
    {
        public static volatile int result;

        [Test("Queue Foreach")]
        [DontOptimize]
        public void Queue_Foreach()
        {
            int ct = 0;
            foreach (var player in queue)
            {
                ct += player.no;
            }
            result = ct;
        }

        [Test("Queue Foreach (Optimize)")]
        public void Queue_Foreach_Optimized()
        {
            int ct = 0;
            foreach (var player in queue)
            {
                ct += player.no;
            }
            result = ct;
        }

        //[Test("Queue Foreach X5")]
        //[DontOptimize]
        //public void Queue_Foreach_X5()
        //{
        //    int ct = 0;
        //    foreach (var player in queue)
        //    {
        //        ct += player.no + player.a0 + player.a1 + player.a10 + player.a3;
        //    }
        //    result = ct;
        //    if (CanPrint) Log("Queue X5 " + ct);
        //}

        //[Test("Queue Foreach X5 Optimized")]
        //public void Queue_Foreach_X5_Optimized()
        //{
        //    int ct = 0;
        //    foreach (var player in queue)
        //    {
        //        ct += player.no + player.a0 + player.a1 + player.a10 + player.a3;
        //    }
        //    result = ct;
        //    if (CanPrint) Log("Queue X5 Optimized " + ct);
        //}
    }
}
