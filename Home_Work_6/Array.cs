using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_6
{
    public class Array
    { 
        private const int TWO = 2;
        private int[] _array;

        public int Size { get; set; }

        public Array(int size)
        {
            Size = size;
            _array = new int[Size];
        }

        public int this[int index]
        {
            get
            {
                return _array[index];
            }

            set
            {
                _array[index] = Convert.ToInt32(Math.Pow(value, TWO));
            }
        }
    }
}
