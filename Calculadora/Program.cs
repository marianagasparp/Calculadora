using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            List<long> listaResultados = new List<long>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();

            
            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
                listaResultados.Add(operacao.resultado);
                Console.WriteLine($"Proximas operações: ");
                foreach (Operacoes item in filaOperacoes)
                {
                    Console.WriteLine($"{item.valorA} {item.operador} {item.valorB}");
                }
            }
                Console.WriteLine($"Sem operações restantes! Resultados:");
                foreach (long item in listaResultados)
                {
                        Console.WriteLine($"{item}");
                }


          
           
        }
    }
}
