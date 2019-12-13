using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    class AnotherThread
    {
        public static void OtherThread<T>(T[] arr, Func<T, T, bool> Compare)
        {
            void thread()
            {
                CustomBubbleSort.CustomSort<T>(arr, Compare);
                WriteArray.WriteArr(arr);
            }
            new Thread(thread).Start();
        }
    }
}
