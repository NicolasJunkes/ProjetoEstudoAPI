using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SubtracaoAPI.Repository
{
    public class Repositorio<T> : IDisposable, IRepositorio<T> where T : class
    {
        protected readonly DbContext contexto;
        public Repositorio(DbContext contexto)
        {
            this.contexto = contexto;
        }

        public virtual void Adicionar(T item)
        {
            contexto.Set<T>().Add(item);
            contexto.SaveChanges();
        }

        public void Editar(T item)
        {
            contexto.Entry(item).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Remover(T item)
        {
            contexto.Set<T>().Remove(item);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}