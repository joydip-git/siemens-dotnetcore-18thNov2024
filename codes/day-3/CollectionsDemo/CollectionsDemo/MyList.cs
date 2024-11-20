using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class MyList<T> : IEnumerable<T>
    {
        T[] items;
        static int index = 0;
        public MyList()
        {
            items = new T[4];
        }
        public int Count => index;
        public int Capacity => items.Length;

        public T this[int x]
        {
            get => items[x];
            //set => items[x] = value;
        }
        public void Add(T item)
        {
            if (index == items.Length)
            {
                T[]? values = new T[items.Length];
                items.CopyTo(values, 0);
                items = new T[items.Length * 2];
                values.CopyTo(items, 0);
                values = null;
            }
            items[index] = item;
            index++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            Type tType = typeof(T);
            Type[] all = tType.GetInterfaces();

            if (all.Length > 0)
            {
                var filtered = all.Where(t => t == typeof(IComparable<T>));
                if (filtered != null && filtered.Any())
                {
                    for (int i = 0; i < index; i++)
                    {
                        for (int j = i + 1; j < index; j++)
                        {
                            //if (items[i] > items[j])
                            IComparable<T> first = (IComparable<T>)items[i];
                            if (first?.CompareTo(items[j]) > 0)
                            {
                                T temp = items[i];
                                items[i] = items[j];
                                items[j] = temp;
                            }
                        }
                    }

                }
            }
            else
            {
                throw new Exception("IComparable is not implemented..");
            }
        }
        public void Sort(IComparer<T> comparer)
        {
            //Type tType = typeof(T);
            //Type[] all = tType.GetInterfaces();

            //if (all.Length > 0)
            //{
            //    var filtered = all.Where(t => t == typeof(IComparable<T>));
            //    if (filtered != null && filtered.Any())
            //    {
            for (int i = 0; i < index; i++)
            {
                for (int j = i + 1; j < index; j++)
                {
                    //if (items[i] > items[j])
                    
                    if (comparer.Compare(items[i], items[j])>0)
                    {
                        T temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }

        }
        //}
        //else
        //{
        //    throw new Exception("IComparable is not implemented..");
        //}
    }
}
