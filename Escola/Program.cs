using System.Collections.Generic;
using System.Linq;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            //Console.WriteLine(operation);

            var aluno = new List<string>();
            char choice = 's';
           
            do
            { 
                Console.WriteLine("============== MENU ============== ");
                Console.WriteLine();
                Console.WriteLine(" Escolha a operacao que deseja realizar:");
                Console.WriteLine(" 1- Cadastrar Aluno.");
                Console.WriteLine(" 2- Consultar Todos Alunos.");
                Console.WriteLine(" 3- Remover Aluno.");
                Console.WriteLine(" 4- Actualizar Aluno");
                Console.WriteLine();
                Console.WriteLine("====================================");
                Console.WriteLine();

                int operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case 1:

                        Console.WriteLine("Insira o nome do aluno/a: ");
                        string nomeAluno = Console.ReadLine();
                        aluno.Add(nomeAluno);

                        Console.WriteLine("Insira a idade do aluno/a: ");
                        int idadeAluno = Convert.ToInt32(Console.ReadLine());
                        aluno.Add(Convert.ToString(idadeAluno));

                        Console.WriteLine("Insira o numero de matricula: ");
                        int numMatricula = Convert.ToInt32(Console.ReadLine());
                        aluno.Add(Convert.ToString(numMatricula));

                        Console.WriteLine("Insira o sexo do aluno/a");
                        char sexo = Convert.ToChar(Console.ReadLine());
                        aluno.Add(Convert.ToString(sexo));
                        Console.WriteLine("==============================");

                        break;

                    case 2:

                        if (!aluno.Equals(""))
                        {
                            foreach (var alunos in aluno)
                            {
                                Console.WriteLine(alunos);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum resultado encontrado");
                        }

                        Console.WriteLine("Deseja continuar? [S/N]");
                        choice = Convert.ToChar(Console.ReadLine());

                        break;

                    case 3:
                        Console.Write("Insira o numero de matricula: ");
                        numMatricula = Convert.ToInt32(Console.ReadLine());
                        aluno.Remove(Convert.ToString(numMatricula));
                        Console.Write("Insira o nome: ");
                        nomeAluno = Console.ReadLine();
                        aluno.Remove(nomeAluno);
                        Console.Write("Insira a idade: ");
                        idadeAluno = Convert.ToInt32(Console.ReadLine());
                        aluno.Remove(Convert.ToString(idadeAluno));
                        Console.Write("Insira o sexo: ");
                        sexo = Convert.ToChar(Console.ReadLine());
                        aluno.Remove(Convert.ToString(sexo));
                        break;

                        case 4:
                        Console.WriteLine("Em construcao. 404 Error");
                        break;

                    default:
                        Console.WriteLine("Escolha invalida");
                        break;
                }

                Console.WriteLine("Deseja continuar? [S/N]");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 's');
        }
    }
}