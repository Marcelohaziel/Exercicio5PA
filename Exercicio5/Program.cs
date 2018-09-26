using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media de notas");
            Console.WriteLine();

            int i = 1;
            int s = 0;

            while (i <= 5)
            {
                Console.Write("Digite a nota da   " + i + " prova: ");
                s += Convert.ToInt32(Console.ReadLine());

                i++;
            }

            double media = s / 5;

            Console.WriteLine();

            Console.WriteLine("Media aritmedica: " + media);

            Console.ReadKey();
        }
    }
}
