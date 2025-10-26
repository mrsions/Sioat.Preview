using System;
using System.Collections.Generic;

using SIOAT.Optimize;

using UnityEngine.Assertions;

using static SIOAT.Test.TestData;

namespace SIOAT.Test
{
    public class Foreach_Full_Struct
    {
        public static volatile int result;

        [Test("List Foreach")]
        [DontOptimize]
        public void List_Foreach()
        {
            int ct = 0;
            foreach (var vect in vectList)
            {
                ct += vect.z;
            }
            result = ct;
        }



        [Test("#List Index Loop")]
        [DontOptimize]
        public void List_Index_Loop()
        {
            int ct = 0;
            int size = vectList.Count;
            for (int i = 0; i < size; i++)
            {
                ct += vectList[i].z;
            }
            result = ct;
        }



        [Test("#Array Index Loop")]
        [DontOptimize]
        public void Array_Index_Loop()
        {
            int ct = 0;
            var arr = vectArray;
            for (int i = 0, size = arr.Length; i < size; i++)
            {
                var vect = arr[i];
                ct += vect.z;
            }
            result = ct;
        }



        [Test("#Array Foreach")]
        [DontOptimize]
        public void Array_Foreach()
        {
            int ct = 0;
            foreach (var vect in vectArray)
            {
                ct += vect.z;
            }
            result = ct;
        }
    }
}