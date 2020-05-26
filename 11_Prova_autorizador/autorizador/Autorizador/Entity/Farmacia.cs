using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorizador.Entity
{
    class Farmacia
    {
        public long CodFarm { get; set; }
        public long CodFili { get; set; }
        public long CnpjFarm { get; set; }
        public string NomeFarm { get; set; }
        public string MatrizFarm { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFim { get; set; }
    }
}

//DateTime dateTime = DateTime.ParseExact(ds.Tables[0].Rows[0][0].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);