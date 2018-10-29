using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Linq.Expressions;

namespace Sorts
{
    class Program
    {
        static string SomeString { get; set; }
        delegate void Printer();      

        static void DoSomething(ref int number)
        {
            number = 456;
        }

        static void DoSomething2(ClassA input)
        {
            input = new ClassA() { SomeNumber2 = 123 };
        }

        struct MyStruct
        {
            struct Inside
            {
                int NumberA { get; set; }
                double NumberB { get; set; }
            }

            public ClassA GetSomeNumber()
            {
                Inside inside = new Inside();

                var temp = inside;

                return new ClassA();
            }
        }

        static int Factorial(int n)
        {

            if (n == 1)
                return 1;
            return n * Factorial(n - 1);  
        }

        static void Main(string[] args)
        {
            var result = Factorial(3);
            string[] arr = new string[] { "asas", "xaxsa" };
             
            int MyNumber = 123;

            ClassA cla = new ClassA() { SomeNumber2 = 111 };

            DoSomething2(cla);

            var cla2 = cla;
            DoSomething(ref MyNumber);

            //List<Printer> printers = new List<Printer>();
          
            //for (int i = 0; i < 10; i++)
            //{
            //    printers.Add(delegate { Console.WriteLine(i); });
            //}

            //foreach (var printer in printers)
            //{
            //    printer();
            //}

            //DateTime? date = null;

            //if (date == null)
            //{

            //}
            //int[] array = new int[] { 5, 7, 8, 9, 6, 3, 2, 5, 8, 7, 1, 54, 789, 456, 3, 6, 5, 8, 7, 4, 2, 6, 9, 2, 2, 4, 5 };

            //Class1 cl = new Class1();
            //QuickSort(array, 0, array.Length - 1);

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + "; ");
            //}
            //GetString();
            //Thread.Sleep(5007);
            //Console.WriteLine(SomeString); 

            //ClassA cla = new ClassA();

            //ClassA.NumberA = 66;
            //ClassA.NumberB = 99;


            Console.ReadLine();




        }

        static async Task<string> GetString()
        {
            await Task.Delay(5000);

           
            SomeString = "FromMethod";

            return SomeString;
        }

       // static void SomeMethod(ref )
        static void QuickSort(int []array, int left, int right)
        {
            if(left < right)
            {

                int pivot = array[left];
                int boundary = left;
                for (int i = left + 1; i <= right; i++)
                {
                    if (array[i] < pivot)
                    {
                        Swap(array, i, ++boundary);
                    }
                }

                Swap(array, left, boundary);
                QuickSort(array, left, boundary);
                QuickSort(array, ++boundary, right);
            }
          
        }

        static void Swap(int []array, int index1, int index2)
        {
            int pom = array[index1];
            array[index1] = array[index2];
            array[index2] = pom;

        }
    }
}
