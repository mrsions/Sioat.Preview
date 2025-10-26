using System.Collections.Generic;

using SIOAT.Optimize;

using UnityEngine.Assertions;

using static SIOAT.Test.TestData;

namespace SIOAT.Test
{
    public class Foreach_Full_Optimize
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



        [Test("#List Index Loop")]
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



        [Test("#Array Index Loop")]
        public void Array_Index_Loop()
        {
            int ct = 0;
            var arr = array;
            for (int i = 0, size = arr.Length; i < size; i++)
            {
                var p = arr[i];
                ct += p.no;
            }
            result = ct;
        }



        [Test("#Array Foreach")]
        public void Array_Foreach()
        {
            int ct = 0;
            foreach (var p in array)
            {
                ct += p.no;
            }
            result = ct;
        }
    }
}