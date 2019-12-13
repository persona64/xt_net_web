using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    class CustomBubbleSort
    {
        public static event Action IsSort = delegate { Console.WriteLine("Сортировка завершена"); };
        public static void CustomSort<T>(T[] arr, Func<T, T, bool> Compare)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Compare(arr[j], arr[i]))
                    {
                        var temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            IsSort.Invoke();
        }
    }
}
