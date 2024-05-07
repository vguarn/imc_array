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
            string[] nome = new string[4];
            double[] peso = new double[4];
            double[] altura = new double[4];
            double[] imc = new double[4];
            string[] imc2 = new string[4];
            int acima = 0;

            for (int i = 0; i <= 4; i++)
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
                    acima++;
                }
                if (imc[i] >= 30.0 && imc[i] <= 34.9)
                {
                    imc2[i] = "Obesidade grau I!";
                    acima++;
                    
                }
                if (imc[i] >= 35.0 && imc[i] <= 39.9)
                {
                    imc2[i] = "Obesidade grau II!";
                    acima++;
                }
                if (imc[i] > 40.0)
                {
                    imc2[i] = "Obesidade grau III!";
                    acima++;
                }
            }

            for (int j =0; j<=4; j++)
            { 
                Console.WriteLine("Nome: " + nome[j]);
                Console.WriteLine("Peso: " + peso[j]);
                Console.WriteLine("IMC: " + imc2[j]);
            }
             int acimapeso = acima / 100;

            Console.WriteLine(acima + " pessoas estão acima do peso.");
           

            Console.ReadKey();
        }
    }
}
