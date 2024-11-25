using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcentric
{
    internal class Sort
    {
        private int[] array;
        public Sort(int[] array)
        {
            this.array = array;
        }
        public int[] sortArrayUsingBubbleSort()
        {
            int arraySize = array.Length;
            for (int i = 0; i < arraySize - 1; i++)
            {
                for (int j = 0; j < arraySize - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
