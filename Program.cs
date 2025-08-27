using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Queue<double> resultadosFila = new Queue<double>();
            Stack<double> resultadosPilha = new Stack<double>();
            List<double> resultadosLista = new List<double>();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("           Calculadora Avançada");
            Console.WriteLine("------------------------------------------");

            bool continuar = true;
            while (continuar)
            {


                Console.WriteLine("\nMenu de Opções:");
                Console.WriteLine("1. Realizar um novo cálculo");
                Console.WriteLine("2. Imprimir resultados acumulados");
                Console.WriteLine("3. Sair");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RealizarCalculo(resultadosFila, resultadosPilha, resultadosLista);
                        break;
                    case "2":
                        ImprimirResultados(resultadosFila, resultadosPilha, resultadosLista);
                        break;
                    case "3":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção do menu.");
                        break;
                }
            }
            Console.WriteLine("\nObrigado por usar a calculadora!");
        }

        static void RealizarCalculo(Queue<double> fila, Stack<double> pilha, List<double> lista)
        {
            Console.WriteLine("\n--- Realizar Novo Cálculo ---");
            string operacao;

            Console.Write("Digite a operação (+, -, * (multiplicação), /, ^ (Potência), %, cos, tan, rq (raiz quadrada)): ");
            operacao = Console.ReadLine();

            double num2 = 0;
            bool operacaoValida = true;


            switch (operacao)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "^":
                case "%":

                    while (true)
                    {
                        Console.Write("Digite o primeiro número: ");
                        if (double.TryParse(Console.ReadLine(), out double num1)) break;
                        Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    }
                    while (true)
                    {
                        Console.Write("Digite o segundo número: ");
                        if (double.TryParse(Console.ReadLine(), out num2)) break;
                        Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    }
                    break;
                case "cos":
                case "tan":
                case "rq":

                    while (true)
                    {
                        Console.Write("Digite o número: ");
                        if (double.TryParse(Console.ReadLine(), out double num1)) break;
                        Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    }
                    break;
                default:
                    Console.WriteLine("Erro: Operação inválida.");
                    operacaoValida = false;
                    return;
            }

            double resultado = 0; // Para inicializar a variavel do resultado
            string expressao = ""; // Para armazenar a expressao

            /*
             * 
             * 
             * 
             *  Onde colocar a parte do calculo
             * 
             * 
             * 
             * 
             */


            if (operacaoValida)
            {
                Console.WriteLine($"\nResultado: {expressao} = {resultado}");

                // Armazenar os resultados nas 3 estruturas 
                fila.Enqueue(resultado); 
                pilha.Push(resultado);     
                lista.Add(resultado);    

                Console.WriteLine("Resultado armazenado com sucesso nas 3 estruturas de dados.");
            }

        } 
            
            static void ImprimirResultados(Queue<double> fila, Stack<double> pilha, List<double> lista)
            {
                Console.WriteLine("\n--- Imprimir Resultados Acumulados ---");
                Console.WriteLine("Escolha a estrutura de dados para impressão:");
                Console.WriteLine("1. Fila (FIFO - Primeiro a Entrar, Primeiro a Sair)");
                Console.WriteLine("2. Pilha (LIFO - Último a Entrar, Primeiro a Sair)");
                Console.WriteLine("3. Lista (Ordem de Inserção)");

                Console.WriteLine("Sua escolha:");
                string escolha = Console.ReadLine();

                switch(escolha)
                {
                    case "1":
                        if (fila.Count == 0)
                        {
                            Console.WriteLine("Nenhum resultado acumulado na fila.");
                        }
                        else
                        {
                            Console.WriteLine("\nResultados na Fila:");
                            foreach (double item in fila)
                            {
                                Console.WriteLine($"  -> {item}");
                            }
                        }
                        break;

                    case "2":
                        if (pilha.Count == 0)
                        {
                            Console.WriteLine("Nenhum Resultado na Pilha");
                        }
                        else
                        {
                            Console.WriteLine("Resultados na Pilha");
                            foreach (double item in pilha)
                            {
                                Console.WriteLine($"  -> {item}");
                            }   
                        }
                        break;

                    case "3":
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("Nenhum resultado na lista");
                        }
                        else
                        {
                            Console.WriteLine("Resultados na lista:");
                            foreach (double item in lista)
                            {
                                Console.WriteLine($"  -> {item}");
                            }
                        }
                        break;
                        default:
                        Console.WriteLine("Opção inválida. Retornando ao menu principal.");
                        break;
                    }


                }

            }
        }






