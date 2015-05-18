using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Exemplo.Dominio.Classes;

namespace Exemplo.Infraestrutura.Database
{
    public class Exemplo : UnidadeTrabalho, IExemplo
    {
        public Exemplo()
            : base("name=ExemploBDEntities")
        {

        }
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
