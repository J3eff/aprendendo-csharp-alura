﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2; // C# da prioridade para divisão/multiplicão e depois soma e a subtração, existe uma precedencia de operadores.
            Console.WriteLine(idade);

            idade = (10 + 5) * 2; 
            Console.WriteLine("Sua idade é " + idade + "!"); // Concatenção de texto com valores... 

            Console.WriteLine("Execução finalizada. Tecle  enter para sair. . .");
            Console.ReadLine();
        }
    }
}
