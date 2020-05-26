using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorizador.Entity
{
    class Fornecedor
    {
        public long CodForn { get; set; }
        public long CnpjForn { get; set; }
        public string NomeForn { get; set; }
        public long CodEan { get; set; }
        public string NomeProd { get; set; }
        public long TpProd { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFim { get; set; }
    }
}
