using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.Practices.ServiceLocation;
using ProjetCDD.Domain.Repositorios;
using ProjetCDD.Infra.Data.configurations;
using ProjetCDD.Infra.Data.Configuration;
using ProjetCDD.Infra.Data.Contexto;

namespace ProjetCDD.Infra.Data.Repositorio
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        protected readonly ContextoBanco _Contexto;

        public RepositorioBase()
        {
            var gerenciador = (GerenciadorDeRepositorio) ServiceLocator.Current.GetInstance<IGerenciadorDeRepositorio>();
            _Contexto = gerenciador.Contexto;
        }
        public void Alterar(TEntity obj)
        {
            _Contexto.Entry(obj).State = EntityState.Modified;
        }

        public void Inserir(TEntity obj)
        {
            _Contexto.Set<TEntity>().Add(obj);
        }

        public TEntity RecuperaPorId(int id)
        {
           return _Contexto.Set<TEntity>().Find(id);
        }

        public IList<TEntity> RecuperaTodos()
        {
          return  _Contexto.Set<TEntity>().ToList();
        }

        public void Remover(int id)
        {
            TEntity obj = RecuperaPorId(id);
                Remover(obj);
        }

        public void Remover(TEntity obj)
        {
            _Contexto.Set<TEntity>().Remove(obj);
        }
    }
}
