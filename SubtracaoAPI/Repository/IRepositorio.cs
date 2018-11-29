using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubtracaoAPI.Repository
{
    public interface IRepositorio<T> : IDisposable where T : class 
    {
        void Adicionar(T item);
        void Remover(T item);
        void Editar(T item);
    }
}