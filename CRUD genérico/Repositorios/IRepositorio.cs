using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_genérico.Entidades;
namespace CRUD_genérico.Repositorios
{
    public interface IRepositorio<T> where T : Entidade
    {
        void Adicionar(T entidade);
        bool Remover(int id);
        List<T> ListarTodos();
        T? BuscarPorId(int id);
    }
}
