using Sioat.Optimize;
using UnityEngine.Scripting;
using static Sioat.Benchmark.TestData;

namespace Sioat.Benchmark.Collections
{
    [Preserve]
    public class ListForeach_Test
    {
        public static volatile int result;

        [Test("List Foreach")]
        [DontOptimize]
        public void List_Foreach()
        {
            int ct = 0;
            foreach (var player in list)
            {
                ct += player.no;
            }
            result = ct;
        }



        [Test("List Index-For")]
        [DontOptimize]
        public void List_Index_Loop()
        {
            int ct = 0;
            int size = list.Count;
            for (int i = 0; i < size; i++)
            {
                ct += list[i].no;
            }
            result = ct;
        }


        //[Test("#List Reverse Index Loop")]
        //[DontOptimize]
        //public void List_Reverse_Index_Loop()
        //{
        //    int ct = 0;
        //    for (int i = list.Count - 1; i >= 0; i--)
        //    {
        //        ct += list[i].no;
        //    }
        //    result = ct;
        //}

        [Test("List Foreach (Optimize)")]
        public void List_Foreach_Optimize()
        {
            int ct = 0;
            foreach (var player in list)
            {
                ct += player.no;
            }
            result = ct;
        }




        //[Test("List Index Loop Opt")]
        //public void List_Index_Loop_Opt()
        //{
        //    int ct = 0;
        //    int size = list.Count;
        //    for (int i = 0; i < size; i++)
        //    {
        //        ct += list[i].no;
        //    }
        //    result = ct;
        //}

        //[Test("List Index Loop Opt2")]
        //public void List_Index_Loop_Opt2()
        //{
        //    int ct = 0;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        ct += list[i].no;
        //    }
        //    result = ct;
        //}

        //[Test("List Reverse Index Loop Opt")]
        //public void List_Reverse_Index_Loop_Opt()
        //{
        //    int ct = 0;
        //    for (int i = list.Count - 1; i >= 0; i--)
        //    {
        //        ct += list[i].no;
        //    }
        //    result = ct;
        //}

        //[Test("List Foreach (Optimize+Fast)")]
        //public void List_Foreach_Fast()
        //{
        //    int ct = 0;
        //    foreach (var player in list._Fast())
        //    {
        //        ct += player.no;
        //    }
        //    result = ct;
        //}

        //[Test("List Foreach (Optimize+Idx)")]
        //public void List_Foreach_Idx()
        //{
        //    int ct = 0;
        //    foreach (var player in list._Idx())
        //    {
        //        ct += player.no;
        //    }
        //    result = ct;
        //}

        //[Test("List Foreach (Optimize+Idx+Fast)")]
        //public void List_Foreach_IdxFast()
        //{
        //    int ct = 0;
        //    foreach (var player in list._Fast()._Idx())
        //    {
        //        ct += player.no;
        //    }
        //    result = ct;
        //}

        //[Test("Impl-List Foreach")]
        //public void foreach_implList()
        //{
        //    int ct = 0;
        //    foreach (var player in implList)
        //    {
        //        ct += player.no;
        //    }
        //    result = ct;
        //}

        //[Test("Custom-Enumerator-Impl-List Foreach")]
        //public void foreach_customEnumeratorImplList()
        //{
        //    int ct = 0;
        //    foreach (var player in customEnumList)
        //    {
        //        ct += player.no;
        //    }
        //    result = ct;
        //}

    }
}