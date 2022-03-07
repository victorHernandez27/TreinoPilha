using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoPilha
{
    internal class PilhaLivro
    {
        public Livro Topo { get; set; }
        public int quantidade { get; set; }

        public bool achei { get; set; }
        public bool achei2 { get; set; }

        public PilhaLivro()
        {
            Topo = null;
            quantidade = 0;
            achei = false;
            achei2 = false;
        }

        public void push(Livro aux)
        {
            aux.Anterior = Topo;
            Topo = aux;
            quantidade++;
        }

        public void pop()
        {
            if (Vazia())
            {
                Console.WriteLine(" === PILHA VAZIA ===");
            }
            else
            {
                Topo = Topo.Anterior;
                quantidade--;
                Console.WriteLine(" Livro Removido Da Pilha");
            }
        }

        public void print()
        {
            if (Vazia())
            {
                Console.WriteLine("===PILHA VAZIA===");
            }
            else
            {
                Livro aux = Topo;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;

                }while(aux != null);
            }
        }

        public void BuscarTitulo(string titulo)
        {
            if (Vazia())
            {
                Console.WriteLine("===PILHA VAZIA===");
            }
            else
            {   Livro aux = Topo;
                do
                {
                    if (titulo.Contains(aux.Titulo))
                    {
                        Console.WriteLine(aux.ToString());
                        achei = true;
                    }
                    aux = aux.Anterior;
                } while (aux != null);

                if (achei != true)
                {
                    Console.WriteLine("Livro Não Cadastrado");
                }
            }
        }
        public void BuscarISBN(int isbn)
        {
            if (Vazia())
            {
                Console.WriteLine("===PILHA VAZIA===");
            }
            else
            {
                Livro aux = Topo;
                do
                {
                    if (isbn == aux.ISBN)
                    {
                        Console.WriteLine(aux.ToString());
                        achei2 = true;
                    }
                    aux = aux.Anterior;
                } while (aux != null);

                if (achei2 != true)
                {
                    Console.WriteLine("Livro Não Cadastrado");
                }
            }
        }


        public bool Vazia()
        {
            if(Topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
