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
                    try
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
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\nOcorreu um erro inesperado: {ex.Message}");
                    }
                }

                Console.WriteLine("\nObrigado por usar a calculadora!");
            }

           
          
