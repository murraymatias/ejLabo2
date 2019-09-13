using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int CompareInts(int x, int y)
        {
            return y - x;
        }

        static void Main(string[] args)
        {

            List<int> lista = new List<int>();
            Stack<int> pila = new Stack<int>();
            Queue<int> fila = new Queue<int>();

            Random ran = new Random();

            for(int i = 0; i<5; i++)
            {
                lista.Add(ran.Next(1, 100));
            }
            lista.Sort(CompareInts);
            Console.WriteLine("Lista");
            foreach (int item in lista)
            {
                Console.Write("{0}, ", item);
                pila.Push(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pila");
            for (int i = 0; i < 5; i++)
            {
                int item = pila.Pop();
                Console.Write("{0}, ",item);
                fila.Enqueue(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Cola");
            for (int i = 0; i < 5; i++)
            {
                int item = fila.Dequeue();
                Console.Write("{0}, ", item);
            }


            Console.WriteLine();

           /* lista.Sort(CompareInts);
            foreach (int item in lista)
            {
                Console.Write("{0}, ", item);
            }*/


            Console.ReadKey();
        }
    }
}
