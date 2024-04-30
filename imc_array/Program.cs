using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] peso = new double[5];
            double[] altura = new double[5];
            double[] imc = new double[5];
            string[] imc2 = new string[5];
            int[] acima = new int[5];

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Digite o nome: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite o peso: ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura: ");
                altura[i] = double.Parse(Console.ReadLine());
                imc[i] = (altura[i] * altura[i])/ peso[i];

                if (imc[i] <=18.5)
                {
                    imc2[i] = "Abaixo do peso!";   
                }
                if (imc[i] >= 18.6 && imc[i]<=24.9)
                {
                    imc2[i] = "Peso ideal!";
                }
                if (imc[i] >= 25.0&& imc[i] <= 29.9)
                {
                    imc2[i] = "Levemente acima do peso!";
                }
                if (imc[i] >= 30.0 && imc[i] <= 34.9)
                {
                    imc2[i] = "Obesidade grau I!";
                }
                if (imc[i] >= 35.0 && imc[i] <= 39.9)
                {
                    imc2[i] = "Obesidade grau II!";
                }
                if (imc[i] > 40.0)
                {
                    imc2[i] = "Obesidade grau III!";
                }
            }

           

            Console.ReadKey();
        }
    }
}
