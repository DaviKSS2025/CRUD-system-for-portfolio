using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_genérico.Entidades;

namespace CRUD_genérico.Repositorios
{
    public class Repositorio<T> : IRepositorio<T> where T : Entidade
    {
        private readonly List<T> _entidades = new List<T>();
        private int _proximoID = 1;

        public void Adicionar(T entidade)
        {
            entidade.Id = _proximoID++;
            _entidades.Add(entidade);
        }
        public bool Remover(int id)
        {
            for (int i = 0; i < _entidades.Count; i++)
            {
                if (_entidades[i].Id == id)
                {
                    _entidades.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public List<T> ListarTodos()
        {
            return _entidades;
        }
        public T? BuscarPorId(int id)
        {
            for (int i = 0; i < _entidades.Count; i++)
            {
                if (_entidades[i].Id == id)
                {
                    return _entidades[i];
                }
            }
            return null;
        }
    }
}
