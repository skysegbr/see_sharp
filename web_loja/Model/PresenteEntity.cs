using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class PresenteEntity
    {
        public int codPresente { get; set; }
        public string descPresente { get; set; }
        public string corPresente { get; set; }
        public string tamanhoPresente { get; set; }
        public double precoPresente { get; set; }
        public int codMarca { get; set; }
        public string descMarca { get; set; }
        public int codTipo { get; set; }
        public string descTipo { get; set; }
        public int codFinalidade { get; set; }
        public string descFinalidade { get; set; }
        public int codFornecedor { get; set; }
        public string nomeFornecedor { get; set; }
    }
}