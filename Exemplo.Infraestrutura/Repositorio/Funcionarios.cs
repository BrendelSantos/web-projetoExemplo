using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo.Dominio.Interfaces;
using Exemplo.Dominio.Classes;
using Exemplo.Infraestrutura.Database;

namespace Exemplo.Infraestrutura.Repositorio
{
    public class Funcionarios : IFuncionarios
    {
        private IQueryable<Funcionario> funcionarios;
        private IExemplo unidadeTrabalho;

         private  Funcionarios(IQueryable<Funcionario> funcionarios, IExemplo unidadeTrabalho)
        {
            this.funcionarios = funcionarios;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        public Funcionarios(IExemplo iExemplo, IExemplo unidadeTrabalho) : 
               this(iExemplo.Funcionarios, unidadeTrabalho) { }

        public void Cadastrar(Funcionario funcionario)
        {
            unidadeTrabalho.RegistrarNovo(funcionario);
            unidadeTrabalho.Salvar();
        }

        public void Atualizar(Funcionario funcionario)
        {
            unidadeTrabalho.RegistrarAlterado(funcionario);
            unidadeTrabalho.Salvar();
        }

        public void Remover(Funcionario funcionario)
        {
            unidadeTrabalho.RegistrarRemovido(funcionario);
            unidadeTrabalho.Salvar();
        }

        public Funcionario ResultadoUnico(int idFunc)
        {
            return funcionarios.SingleOrDefault(f => f.id == idFunc);
        }

        public ICollection<Funcionario> Listar()
        {
            return funcionarios.OrderBy(f => f.nome).ToList();
        }

        public bool ContemRegistro()
        {
            throw new NotImplementedException();
        }

        public int TotalRegistros()
        {
            throw new NotImplementedException();
        }

    }
}
