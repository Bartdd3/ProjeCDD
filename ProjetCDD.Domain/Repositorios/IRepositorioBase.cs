using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCDD.Domain.Repositorios
{
    public interface IRepositorioBase<TEntity> where TEntity : class

    {
        IList<TEntity> RecuperaTodos();
        TEntity RecuperaPorId(int id);

        void Inserir(TEntity obj);
        void Alterar(TEntity obj);
        void Remover(TEntity obj);
        void Remover(int id);
    }
}
