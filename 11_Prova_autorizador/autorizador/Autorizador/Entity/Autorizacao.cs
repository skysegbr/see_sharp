using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorizador.Entity
{
    class Autorizacao
    {
        public long CodAutorizacao { get; set; }
        public long OrdemItem { get; set; }
        public long CodFarm { get; set; }
        public long CodFili { get; set; }
        public long CnpjFarm { get; set; }
        public long CodBeneficiario { get; set; }
        public long CodPlas { get; set; }
        public long CnpjPlas { get; set; }
        public long CodProd { get; set; }
        public decimal PrecoFarm { get; set; }
        public decimal PrecoLab { get; set; }
        public long PrecoPmcSaude { get; set; }
        public decimal PrecoAPagar { get; set; }
        public long StaCaptura { get; set; }
        public DateTime DtAutorizacao { get; set; }
    }
}
