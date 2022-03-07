using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoPilha
{
    internal class Livro
    {
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }

        public Livro Anterior { get; set; }

        public Livro(int iSBN, string titulo, int ano)
        {
            ISBN = iSBN;
            Titulo = titulo;
            Ano = ano;
            Anterior = null;
        }

        public override string ToString()
        {
            return "\nISBN: "+ISBN+"\nTítulo: "+Titulo+"\nAno de Publicação: "+Ano;
        }
    }
}
