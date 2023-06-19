using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA11PR2
{
    internal class Program
    {
        public static void Exercicio1()

        {

            int[] vet2;

            int n;


            vet2 = new int[1000];

            Random rand = new Random();

            for (int i = 0; i < 1000; i++)

            {
                vet2[i] = rand.Next(1, 1000);

            }

            Console.WriteLine("digite um número: ");

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)

            {
                if (n == vet2[i])

                {
                    Console.WriteLine("o número digitado esta no vetor.");

                    break;
                }
            }
        }
        public static void Exercicio2()
        {
            int[] vet2;
            int n, cont = 0;


            vet2 = new int[20000];
            Random rand = new Random();

            for (int i = 0; i < 20000; i++)
            {
                vet2[i] = rand.Next(1, 20000);

            }
            Console.WriteLine("digite um número: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 20000; i++)
            {
                if (n == vet2[i])
                {
                    Console.WriteLine("o número digitado esta no vetor.");
                    cont++;

                }
            }

            Console.WriteLine("o número selecionado aparece no vetor " + cont + " vezes");


        }
        public static void Exercicio3()
        {
            int[] vet4;
            int[] vet5;
            int[] vet6;
            vet4 = new int[10];
            vet5 = new int[10];
            vet6 = new int[10];
            Random rand = new Random();


            for (int i = 0; i < 10; i++)
            {
                vet5[i] = rand.Next(1, 1000);
            }
            for (int i = 0; i < 10; i++)
            {
                if (vet5[i] % 2 == 0)
                {
                    vet4[i] = vet5[i] / 2;
                }
                else
                {
                    vet6[i] = vet5[i] * 3;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("numeros pares {0}", vet4[i]);
                Console.WriteLine("numeros impares {0}", vet6[i]);

            }
        }
        public static void Exercicio4()
        {
            int[] vet2;

            vet2 = new int[5000];
            Random rand = new Random();

            for (int i = 0; i < 5000; i++)
            {

                vet2[i] = rand.Next(1, 5000);

            }
            Console.WriteLine("digite um número: ");


            for (int i = 0; i < 5000; i++)
            {
                if (vet2[i] % 2 != 0 && vet2[i] % 3 != 0 && vet2[i] % 5 != 0)
                {
                    Console.WriteLine("o número digitado é um número primo.");
                    Console.WriteLine("números primos {0}", vet2[i]);

                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>MENU<<<<<<<<");
            Console.WriteLine("EXERCICIO 1");
            Console.WriteLine("EXERCICIO 2");
            Console.WriteLine("EXERCICIO 3");
            Console.WriteLine("EXERCICIO 4");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Exercicio1();
                    Console.ReadKey();  
                    break;
                case 2:
                    Exercicio2();
                    Console.ReadKey();
                    break;
                case 3:
                    Exercicio3();
                    Console.ReadKey();
                    break;
                case 4:
                    Exercicio4();
                    Console.ReadKey();
                    break; 
            }

        }
    }
}
