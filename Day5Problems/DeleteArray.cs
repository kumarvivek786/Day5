using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    internal class DeleteArray
    {
        int[] intarray = { 1, 3, 6, 4, 7, 8, 10, 2, 5, 9 };
        double[] doublearray = { 1.3, 3.3, 6.7, 4.8, 7.3, 8.2, 10.9, 2.2, 5.4, 9.6 };
        char[] chararray = { 'a', 'b', 'c', 'g', 'f', 'e' };
        public void DeleteElementInArray()
        {
            bool value = true;
            while (value)
            {
                Console.WriteLine("Select Array to Delete Element\n1.Integers\n2.Float\n3.Char\n4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        DeleteInteger();
                        break;
                    case 2:
                        DeletDouble();
                        break;
                    case 3:
                        DeleteChar();
                        break;
                    case 4:
                        value = false;
                        break;
                }
            }
        }
        public void DeleteInteger()
        {
            int[] arr = new int[10];
            int a = 0;
            Console.WriteLine("Enter Element to be Delete");
            int search = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < intarray.Length; i++)
            {
                if (intarray[i] != search)
                {
                    arr[a] = intarray[i];
                    a++;
                }
            }
            intarray = arr;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(intarray[i]);
            }
        }
        public void DeletDouble()
        {
            double[] arr = new double[10];
            int a = 0;
            Console.WriteLine("Enter Elements to be Deleted");
            double search = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < doublearray.Length; i++)
            {
                if (doublearray[i] != search)
                {
                    arr[a] = doublearray[i];
                    a++;
                }
            }
            doublearray = arr;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(doublearray[i]);
            }
        }
        public void DeleteChar()
        {
            char[] arr = new char[10];
            int a = 0;
            Console.WriteLine("Enter Element to be Delete");
            char search = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < chararray.Length; i++)
            {
                if (chararray[i] != search)
                {
                    arr[a] = chararray[i];
                    a++;
                }
            }
            chararray = arr;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(chararray[i]);
            }
        }
    }
}
