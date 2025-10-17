using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_genérico.Entidades
{
    public class Aluno : Entidade
    {
        private string nome;
        private int idade;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                bool validou = ValidarTexto(value);
                if (validou) 
                { 
                    nome = value;
                }
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (value > 0 && value <= 150)
                {
                    idade = value;
                }
                else
                {
                    EntradaInvalida();
                }
            }
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Id: {Id} | Nome: {Nome} | Idade: {Idade}");
        }
    }
}
