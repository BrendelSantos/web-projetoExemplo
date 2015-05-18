using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo.Dominio.Interfaces;
using Exemplo.Dominio.Classes;
using System.Data.Entity;

namespace Exemplo.Infraestrutura.Database
{
    public interface IExemplo : IUnidadeTrabalho
    {
        DbSet<Funcionario> Funcionarios { get; }
    }
}
