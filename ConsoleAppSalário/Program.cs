using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSalário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu salário bruto: ");
            double s = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do seu vale alimentação: ");
            double v = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos filhos você possui: ");
            double f = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor por filho: ");
            double vf = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas de hora extra você faz: ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor por hora extra: ");
            double vh = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do INSS: ");
            double ins = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do IRPF: ");
            double ir = double.Parse(Console.ReadLine());

            double sl = s + v + (f * vf) + (h * vh) - ins - ir;

            Console.WriteLine("Salário Líquido: R$" + sl);


            Console.ReadKey();

        }
    }
}
