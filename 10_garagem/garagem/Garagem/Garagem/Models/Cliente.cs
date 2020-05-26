using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem.Models
{
    class Cliente : PessoaEntity
    {
        public void Inserir(String Nome, String Telefone)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
        }

        public PessoaEntity Consultar(int id)
        {
            return new PessoaEntity();
        }

    }
}
