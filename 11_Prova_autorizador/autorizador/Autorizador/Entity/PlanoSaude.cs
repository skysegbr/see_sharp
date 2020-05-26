using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorizador.Entity
{
    class PlanoSaude
    {
        public long CodPlas { get; set; }
        public long CnpjPlas { get; set; }
        public string NomePlas { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFim { get; set; }
    }
}
