using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listinha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            string opcao = "1";
            string removendo;
            string delete;

            while (opcao == "1")
            {
                Console.WriteLine("Digite um nome para inserir na lista:");
                string nome = Console.ReadLine();

                lista.Add(nome);
                Console.WriteLine("Deseja inserir outro nome? 1-SIM | 2-NÃO");
                opcao = Console.ReadLine();





            }

            Console.WriteLine("Deseja apagar algum item? 1-SIM | 2-NÃO");
            delete = Console.ReadLine();

            while (delete == "1")
            {


                Console.WriteLine("Deseja apagar qual item?");
                removendo = Console.ReadLine();



                if (lista.Remove(removendo) == true)
                {
                    lista.Remove(removendo);
                    Console.WriteLine("Item remvido com sucesso!");

                }

                else
                {
                    Console.WriteLine("Falha ao remover item");
                }
                Console.WriteLine("Deseja apagar mais algum item? 1-SIM | 2-NÃO");
                delete = Console.ReadLine();

            }



            lista.Sort();
            Console.WriteLine("A lista tem " + lista.Count + " itens:");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
    }

