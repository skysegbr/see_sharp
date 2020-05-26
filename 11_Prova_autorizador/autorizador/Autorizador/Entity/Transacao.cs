using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorizador.Entity
{
    class Transacao
    {
        public long Produto { get; set; }
        public string ProdutoNome { get; set; }
        public long Desconto { get; set; }
        public long Quantidade { get; set; }
        public long ValorAPagar { get; set; }

    }
}
