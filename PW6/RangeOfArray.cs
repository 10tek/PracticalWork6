using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW6
{
    class RangeOfArray
    {
        private int[] _array;

        public int Lenght { get; set; }
        public int EndIndex { get; set; }
        public int BeginIndex { get; set; }

        public RangeOfArray(int beginIndex, int endIndex)
        {
            EndIndex = endIndex;
            BeginIndex = beginIndex;
            Lenght = Math.Abs(endIndex - beginIndex);
            _array = new int[Lenght];
        }


        public int this[int index]
        {
            get
            {
                try
                {
                    if (index < BeginIndex || index >= EndIndex)
                    {
                        throw new Exception("Out of range");
                    }
                    return _array[index - BeginIndex];
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"ERROR! {exception.Message}");
                    return -1;
                }
            }
            set
            {
                try
                {
                    if (index < BeginIndex || index >= EndIndex)
                    {
                        throw new Exception("Out of range");
                    }
                    _array[index - BeginIndex] = value;
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"ERROR! {exception.Message}");
                }
            }
        }
    }
}
