using Sioat.Optimize;

using static Sioat.Benchmark.TestData;

namespace Sioat.Benchmark.Collections
{
    public class ArrayLoop_Test
    {
        public static volatile int result;

        [Test("Array Index-For")]
        [DontOptimize]
        public void Array_Index_Loop()
        {
            int ct = 0;
            var arr = array;
            for (int i = 0; i < arr.Length; i++)
            {
                var p = arr[i];
                ct += p.no;
            }
            result = ct;
        }

        //[Test("#Array Reverse Index Loop")]
        //[DontOptimize]
        //public void Array_Reverse_Index_Loop()
        //{
        //    int ct = 0;
        //    var arr = array;
        //    for (int i = arr.Length - 1; i >= 0; i--)
        //    {
        //        var p = arr[i];
        //        ct += p.no;
        //    }
        //    result = ct;
        //}

        [Test("Array Foreach")]
        [DontOptimize]
        public void Array_Foreach()
        {
            int ct = 0;
            foreach (var p in array)
            {
                ct += p.no;
            }
            result = ct;
        }

        //[Test("Array Index Loop_Opt")]
        //public void Array_Index_Loop_Opt()
        //{
        //    int ct = 0;
        //    var arr = array;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        var p = arr[i];
        //        ct += p.no;
        //    }
        //    result = ct;
        //}


        [Test("Array Foreach (Optimize)")]
        public void Array_Foreach_Opt()
        {
            int ct = 0;
            foreach (var p in array)
            {
                ct += p.no;
            }
            result = ct;
        }

        //[Test("Array Reverse Index Loop Opt")]
        //public void Array_Reverse_Index_Loop_Opt()
        //{
        //    int ct = 0;
        //    var arr = array;
        //    for (int i = arr.Length - 1; i >= 0; i--)
        //    {
        //        var p = arr[i];
        //        ct += p.no;
        //    }
        //    result = ct;
        //}

    }
}