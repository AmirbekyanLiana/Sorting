using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Sorting
    {
        private int sort;
        public int quantity;
        public int[] array;        
        public Sorting()
        {                       
            Console.WriteLine("Enter the number of array elements");
            quantity = Convert.ToInt32(Console.ReadLine());
            array = new int[quantity];
            Console.WriteLine("Enter elements of arrey");
            for (int i = 0; i < quantity; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Sort()
        {
            Console.WriteLine("Choose which sort you want to sort by");
            Console.WriteLine("Bubble: 1" + "\n" + "Insertion: 2" + "\n" + "Selection: 3");
            sort = Convert.ToInt32(Console.ReadLine());
            if (sort == 1)
            {
                Bubble_Sort();
                Console.WriteLine("Bubble Sort_____________________");
                foreach (int n in array)
                {
                    Console.WriteLine(n);
                }
            }
            else if (sort == 2)
            {
                Insertion_Sort();
                Console.WriteLine("Insertion Sort_____________________");
                foreach (int n in array)
                {
                    Console.WriteLine(n);
                }                
            }
            else if (sort == 3)
            {
                Selection_Sort();
                Console.WriteLine("Selection Sort_____________________");
                foreach (int n in array)
                {
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("Sorry, wrong number was entered, please try again");
                Sort();
            }            
        }
        private int[] Bubble_Sort()
        {
            for (int i = 0; i < quantity; i++)
            {
                for (int j = 0; j < quantity; j++)
                {
                    if (array[i] > array[j])
                    {
                        sort = array[i];
                        array[i] = array[j];
                        array[j] = sort;
                    }

                }
            }
            return array;
        }
        private int[] Insertion_Sort()
        {
            for (int i = 0; i < quantity; i++)
            {
                for (int j = 0; j < quantity - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        sort = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = sort;
                    }
                }
            }
            return array;
        }
        private int[] Selection_Sort()
        {
            int j;
            int helpSort;
            for (int i = 0; i < array.Length; i++)
            {
                sort = i;
                
                for (j = i + 1; j < array.Length; j++)
                {
                    if(array[sort] > array[j])
                    {
                        sort = j;
                    }
                }
                helpSort = array[i];
                array[i] = array[sort];
                array[sort] = helpSort;
            }
            return array;
        }                                                
    }
}
