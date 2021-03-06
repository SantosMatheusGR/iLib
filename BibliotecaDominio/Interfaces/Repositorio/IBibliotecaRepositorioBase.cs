﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDominio.Interfaces.Repositorio
{
    public interface IBibliotecaRepositorioBase<TEntidade> where TEntidade : class
    {
        void Adicionar(TEntidade entidade);

        void Atualizar(TEntidade entidade);

        void Remover(TEntidade entidade);

        void Dispose();

        TEntidade ObterPorId(int id);

        IEnumerable<TEntidade> ObterTodos();
    }
}
