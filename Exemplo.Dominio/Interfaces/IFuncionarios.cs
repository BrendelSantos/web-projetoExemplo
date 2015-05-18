using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo.Dominio.Classes;

namespace Exemplo.Dominio.Interfaces
{
    public interface IFuncionarios : IRepositorio<Funcionario>
    {
        void Cadastrar(Funcionario func);
        void Atualizar(Funcionario func);
        void Remover(Funcionario func);
        Funcionario ResultadoUnico(int idFunc);
    }
}
