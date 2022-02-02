using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario;
            salario = 1200.50;

            // O int é um tipo de variável que suporta o valores
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; //Casting o valor
            Console.WriteLine(salarioEmInteiro);

            //O long é uma variavel de 64  bits
            long idade = 1300000000000;
            Console.WriteLine(idade);

            //o shoart é tipo de variavel de 16 bits
            short quantiadeProdutos = 1500;
            Console.WriteLine(quantiadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);
                        
            Console.ReadLine();
        }
    }
}
