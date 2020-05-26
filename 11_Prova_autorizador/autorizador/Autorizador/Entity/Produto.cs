using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorizador.Entity
{
    class Produto
    {
        public long CodProd { get; set; }
        public long Tp_Produto { get; set; }
        public string NomeProd { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFim { get; set; }
    }
}
