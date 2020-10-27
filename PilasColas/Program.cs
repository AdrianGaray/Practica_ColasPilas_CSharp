using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas
{
    class Program
    {
        static void Main(string[] args)
        {
            //PILAS
            string word;
            int counter;
            Stack greetingStack;

            //Usando PUSH y POP
            Console.ForegroundColor = ConsoleColor.Green;
            greetingStack = new Stack();

            // Se ingresa 3 elementos a la Cola
            greetingStack.Push("Hola");
            greetingStack.Push("buenos");
            greetingStack.Push("dias");

            // cuantos elementos tiene la Pila
            counter = greetingStack.Count;
            Console.WriteLine($"Hay {counter} elementos en la pila");

            for (int i = 0; i < counter; i++)
            {
                // Extrar cada elemento de la pila
                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop: {word}");
            }
            Console.WriteLine($"Hay {counter} elementos en la pila");
            Console.ReadKey();

            // Usando PEEK, muestra que valir sigue en la pila sin extraerlo
            Console.ForegroundColor = ConsoleColor.Yellow;
            greetingStack.Push("Hola");
            greetingStack.Push("buenos");
            greetingStack.Push("dias");

            counter = greetingStack.Count;

            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingStack.Peek();
                Console.WriteLine($"Siguiente palabra en la pila: {word}");

                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop: {word}");
            }
            Console.ReadKey();

            // Usando CONTAINS y CLEAR
            Console.ForegroundColor = ConsoleColor.Yellow;
            greetingStack.Push("Hola");
            greetingStack.Push("buenos");
            greetingStack.Push("dias");

            // se valida si la pila contiene la palabra dia, se limpia
            if (greetingStack.Contains("dias"))
            {
                greetingStack.Clear();
            }
            Console.WriteLine($"La pila greetingStack contiene {greetingStack.Count} elementos despues de ejecutar el metodo CLEAR. ");
            Console.ReadKey();

            // Colas
            Console.ForegroundColor = ConsoleColor.Cyan;
            Queue greetingQueue = new Queue();
            greetingQueue.Enqueue("Hola");
            greetingQueue.Enqueue("buenos");
            greetingQueue.Enqueue("dias");

            counter = greetingQueue.Count;
            Console.WriteLine($"Hay {greetingQueue.Count} elementos en la Cola");

            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingQueue.Peek();
                Console.WriteLine($"Siguiente elemento en la Cola: {word}");

                word = (string)greetingQueue.Dequeue();
                Console.WriteLine($"DEQUEUE: {word}");
            }
            Console.WriteLine($"Hay {greetingQueue.Count} elementos en la cola.");
            Console.ReadKey();

            // Usando los metodos CONTAINS y CLEAR.
            Console.ForegroundColor = ConsoleColor.Gray;
            greetingQueue.Enqueue("Hola");
            greetingQueue.Enqueue("buenos");
            greetingQueue.Enqueue("dias");
            if (greetingQueue.Contains("dias"))
            {
                greetingQueue.Clear();
            }
            Console.WriteLine($"La cola greetingQueue contiene {greetingQueue.Count} elementos despues de ejecutar el metodo CLEAR. ");
            Console.ReadKey();
        }
    }
}
