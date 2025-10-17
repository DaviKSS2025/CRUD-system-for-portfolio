using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_genérico.Entidades
{
    public class Livro : Entidade
    {
        private string titulo;
        private string autor;

        public string Titulo
        {
            get 
            { 
                return titulo; 
            } 
            set 
            {
                bool validou = ValidarTexto(value);
                if (validou)
                {
                    titulo = value;
                }
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                bool validou = ValidarTexto(value);
                if (validou)
                {
                    autor = value;
                }
            }
        }
        
        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Id: {Id} | Título: {Titulo} | Autor: {Autor}");
        }
    }
}
