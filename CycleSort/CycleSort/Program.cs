using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleSort
{
    class MyCycleSort
    {
        int[] arr = new int[10] { 11, 1, -9, 44, 17, 6, 8, 4, 1, 9 };
        static void Main(string[] args)
        {
            MyCycleSort demo = new MyCycleSort();
            Console.WriteLine("Unsorted array:");
            for (int i = 0; i < demo.arr.Length; i++) //prints the unsorted array
            {
                Console.Write("{0} ", demo.arr[i]);
            }
            demo.CycleSort();
            Console.WriteLine();
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < demo.arr.Length; i++) //prints the sorted array
            {
                Console.Write("{0} ", demo.arr[i]);
            }
            Console.WriteLine();
        }

        public void CycleSort() //performs cycle sort
        {
            int flag = 0; 
            for (int begin = 0; begin < arr.Length - 2; begin++)
            {
                int selected = arr[begin];
                int position = begin;
                for (int i = begin + 1; i < arr.Length; i++) //finds the correct position where the element should be 
                {
                    if (arr[i] < selected)
                    {
                        position = position + 1;
                    }
                }
                if (position == begin) //if element is already in the correct
                {
                    continue;
                }
                while (selected == arr[position]) //ignoring the duplicate elements
                {
                    position = position + 1;
                }
                if (position != begin) //places the element to its correct position
                {
                    int temp = arr[position];
                    arr[position] = selected;
                    selected = temp;
                    flag = flag + 1;
                }
                while (position != begin) //completing the rest of the cycle
                {
                    position = begin;
                    for (int i = begin + 1; i < arr.Length; i++) //finds the correct position where the element should be 
                    {
                        if (arr[i] < selected)
                        {
                            position = position + 1;
                        }
                    }
                    while (selected == arr[position]) //ignoring the duplicate elements
                    {
                        position = position + 1;
                    }
                    if (selected != arr[position]) //places the element to its correct position
                    {
                        int temp = arr[position];
                        arr[position] = selected;
                        selected = temp;
                        flag = flag + 1;
                    }
                }
            }

        }

    }
}
