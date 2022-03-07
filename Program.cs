using System;

namespace TreinoPilha
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int opcao = 0,opMenuBusca = 0;
            PilhaLivro pilhaLivro = new PilhaLivro();
            do
            {
                Console.Clear();
                opcao = Menu();
                
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        pilhaLivro.push(cadastrarLivro());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        pilhaLivro.pop();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        pilhaLivro.print();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Quantidade de Livros:" + pilhaLivro.quantidade);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        opMenuBusca = MenuBusca();
                        switch (opMenuBusca)
                        {
                            case 1:
                                Console.Clear();
                                pilhaLivro.BuscarTitulo(BuscarTitulo());
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                pilhaLivro.BuscarISBN(BuscarISBN());
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Voltando ao Menu Principal.");
                                Console.ReadKey();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Opção Invalida! Escolha Novamente!");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Invalida! Escolha Novamente!");
                        Console.ReadKey();
                        break;

                }

            } while (opcao != 6);
        }

        public static int Menu()
        {
            int opcaoMenu = 0;

            Console.WriteLine("=====MENU=====");
            Console.WriteLine("\n1-Cadastrar Livro\n2-Remover Livro\n3-Imprimir Livros Cadastrados\n4-Quantidade de Livros Cadastrados\n5-Buscar Livro\n6-Sair");
            opcaoMenu = int.Parse(Console.ReadLine());

            return opcaoMenu;
        }

        public static Livro cadastrarLivro()
        {
                int ISBN, ano;
                string titulo;

            Console.WriteLine("Digite o ISBN: ");
            ISBN = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Título do Livro: ");
            titulo = Console.ReadLine();
            Console.WriteLine("Digite o Ano de Publicação: ");
            ano = int.Parse(Console.ReadLine());

            return new Livro(ISBN, titulo, ano);


        }

        public static int MenuBusca()
        {
            int opcaoMenuBusca = 0;
            Console.WriteLine("=====MENU BUSCA=====");
            Console.WriteLine("\n1-Busca Titulo\n2-Busca ISBN\n3-Sair");
            opcaoMenuBusca = int.Parse(Console.ReadLine());

            return opcaoMenuBusca;
        }

        public static string BuscarTitulo()
        {
            string tituloBusca;
            Console.WriteLine("Digite o Livro a ser buscado: ");
            tituloBusca = Console.ReadLine();

            return tituloBusca;
        }

        public static int BuscarISBN()
        {
            int isbnBusca;
            Console.WriteLine("Digite o ISBN a ser buscado: ");
            isbnBusca = int.Parse(Console.ReadLine());

            return isbnBusca;
        }
    }
}
