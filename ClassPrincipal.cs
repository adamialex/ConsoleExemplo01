using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo01
{
    class ClassPrincipal
    {
       
        
        
        static void Linha()
        {
            Console.Write("================================================");
        }

        
        
        
        
        static void Main(string[] args)
        {
            bool inicio = false;
            ClassConverteString muda = new ClassConverteString();
            ClassOrdena ordena = new ClassOrdena();
            int op;
            
            while (inicio != true)
            {
                Console.Clear();
                Linha();
                Console.SetCursorPosition(15, 1);
                Console.Write("MENU DE OPÇÕES\n");
                Linha();
                Console.SetCursorPosition(10, 4);
                Console.Write("1-Converção de String");
                Console.SetCursorPosition(10, 6);
                Console.Write("2-Ordenar números");
                Console.SetCursorPosition(10, 8);
                Console.Write("3-Finalizar\n\n");
                Linha();
                Console.SetCursorPosition(15, 11);
                Console.Write("Opção[ ]");
                Console.SetCursorPosition(21, 11);

                
                
                try
                {
                    op = int.Parse(Console.ReadLine());
                    
                    if (op == 1)
                    {
                        Console.WriteLine("\nA frase convertida -> " + muda.entrada());
                        Console.WriteLine();
                        Console.Write("Tecle <ENTER> para continuar....");
                    }
                    if (op == 2)
                    {
                        ordena.organizar();
                        Console.Write("Tecle <ENTER> para continuar....");
                    }
                    if (op == 3)
                    {
                        Console.Clear();
                        inicio = true;
                        Console.WriteLine("********************* FIM DE EXECUÇÃO ********************");
                        Console.WriteLine();
                        Console.Write("Tecle <ENTER> para continuar....");
                    }
                    else if (op != 1 && op != 2 && op != 3)
                    {
                        Console.WriteLine("\n\n*****   OPÇÃO INVÁLIDA! TENTE NOVAMENTE!   ************");
                        Console.WriteLine();
                        Console.Write("Tecle <ENTER> para continuar....");
                    }

                    Console.ReadLine();
                }
                
                catch (Exception)
                {
                    Console.Clear();
                    Linha();
                    Console.WriteLine("\n\nDigite um dos valores das opções!\n\nTente novamente , OK !\n\n");
                    //Console.WriteLine();

                    Linha();

                    Console.Write("Tecle <ENTER> para continuar....");
                    Console.ReadLine();
                }



            }
        }
    }
}
