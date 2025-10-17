using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_genérico.Entidades
{
    public abstract class Entidade
    {
        public int Id { get; set; }

        public abstract void MostrarDetalhes();

        public void EntradaInvalida()
        {
            Console.WriteLine("Entrada inválida!");
        }

        public bool ValidarTexto(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                char[] validador = value.ToCharArray();
                bool entrada_valida = true; 
                foreach (char c in validador)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        entrada_valida = false;
                    }
                }
                if (entrada_valida)
                {
                    return true;
                }
                else
                {
                    EntradaInvalida();
                    return false;
                }
            }
            else
            {
                EntradaInvalida();
                return false;
            }
        }
    }
}
