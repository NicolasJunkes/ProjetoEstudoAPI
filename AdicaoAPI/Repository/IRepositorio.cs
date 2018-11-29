using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdicaoAPI.Repository
{
    public interface IRepositorio<T> : IDisposable where T : class
    {
        void Adicionar(T item);
    }
}