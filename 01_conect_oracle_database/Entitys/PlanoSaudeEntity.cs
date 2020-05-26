using System;
using System.Collections.Generic;
using System.Text;

namespace _01_conect_oracle_database.Entitys
{
    public class PlanoSaudeEntity
    {
        public long CodPlas { get; set; }
        public long CnpjPlas { get; set; }
        public string NomePlas { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFim { get; set; }
    }
}
