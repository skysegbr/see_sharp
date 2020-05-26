using Autorizador.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorizador.business
{
    class AutorizadorBusiness
    {
        Autorizacao autorizacao = new Autorizacao();
        
        public void Autorize(int quantidade, long EANProduto)
        {
            Transacao transacao = new Transacao();
            transacao.Produto = 0;

        }
    }
}
