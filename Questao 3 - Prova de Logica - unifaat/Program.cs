using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_3___Prova_de_Logica___unifaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------- ALUNO : OTÁVIO CARDOSO RA 6322528 -------------
            
            Console.WriteLine("Digite o número da fígura geométrica desejada:\n" +
                "1 - Triângulo\n2 - Círculo\n3 - Losango");
            int numero = Convert.ToInt32(Console.ReadLine());
            string figura = null;

            switch (numero)
            {
                case 1: figura = "triangulo"; break;
                case 2: figura = "circulo"; break;
                case 3: figura = "Losango"; break;
            }

            if (figura == "triangulo")
            {
                Console.WriteLine("Digite o valor da base do triângulo:");
                double baset = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da altura do triângulo:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = (baset * altura) / 2;

                Console.WriteLine($"A área do {figura} é de {area}cm2");
            }
            else if (figura == "circulo")
            {
                Console.WriteLine("Digite o valor do raio do círculo:");
                double raio = Convert.ToDouble(Console.ReadLine());

                double area = 3.14 * (Math.Pow(raio,2));

                Console.WriteLine($"A área do {figura} é de {area}cm2");
            }
            else if (figura == "Losango")
            {
                Console.WriteLine("Digite o valor do lado maior do Losango");
                double ladomaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor do lado menor do Losango");
                double ladomenor = Convert.ToDouble(Console.ReadLine());

                double area = (ladomaior * ladomenor) / 2;

                Console.WriteLine($"A área do {figura} é de {area}cm2");
            }
            else
            {
                Console.WriteLine("Erro");
            }

            Console.ReadKey();
           
        }
    }
}
