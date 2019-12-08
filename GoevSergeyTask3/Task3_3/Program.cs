using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfShit = new DynamicArray<int>(12) { 1,2,3,4,5,12,53,764,6,3465,123,65};

            arrayOfShit.Add(23);
            arrayOfShit.AddElementByIndex(43, 7);

            Console.WriteLine(arrayOfShit);

        }
    }

    class DynamicArray<T> : IEnumerable<T>, IEnumerator<T>
    {

        T[] Array;
        int Count = 1;
        int Length = 1;
        int position = -1;

        
        public DynamicArray() => Array = new T[8];

        public DynamicArray(int length) => Array = new T[length];

        public DynamicArray(IEnumerable<T> array)
        {
            Array = array.ToArray();
            Count = Array.Length;
        }

        public void Add(T elem)
        {
            ChangeSize(Count);
            Array[Count] = elem;
            Count++;
        }

        private void ChangeSize(int index)
        {
            if(Length < index || Length == index)
            {
                while (Length < index || Length == index)
                    IncreaseSize();
            }

            T[] garbage = new T[Length];

            for(int i = 1; i <= Array.Length; i++)
            {
                garbage[i] = Array[i];
            }

            Array = garbage;
        }

        private void IncreaseSize()
        {
            if (Length == 0)
            {
                Length = 4;
            }

            Length *= 2;
        }

        public T DeleteElementByIndex(int index)
        {
            T temp;
            T temp2;

            try {temp = Array[index + 1];}
            catch{return default(T);}

            try { temp2 = Array[index + 2]; }
            catch { return default(T); }
            
            for(; index != Array.Length; index++)
            {
                Array[index] = temp;
                temp = temp2;

                try { temp2 = Array[index + 3]; }
                catch { return default(T); }
            }

            Count--;
            return default(T);
        }

        public T AddElementByIndex(T elem, int index)
        {
            ChangeSize(Count + 3);
            T temp = Array[index];
            T temp2;
            T temp3;

            try { temp2 = Array[index + 1]; }
            catch { return default(T); }

            try { temp3 = Array[index + 2]; }
            catch { return default(T); }

            for (; index != Array.Length; index++)
            {
                Array[index + 1] = temp;
                temp = temp2;
                temp2 = temp3;

                try { temp3 = Array[index + 3]; }
                catch { break; }
            }

            Array[index] = elem;
            Count++;
            return default(T);
        }

        public T Current
        {
            get
            {
                return this.Current;
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }     

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Array)
            {
                yield return item;
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < Array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
