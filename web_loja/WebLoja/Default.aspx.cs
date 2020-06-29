using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebLoja
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<PresenteFornecedorEntity> listaFornecedor;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownTipo();
                DropDownMarca();
                DropDownFinalidade();
                DropDownFornecedor();
                TabelaPresente();
            }
            TabelaPresente();
        }

        public T ConverteJSonParaObject<T>(string jsonString)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                T obj = (T)serializer.ReadObject(ms);
                return obj;
            }
            catch
            {
                throw;
            }
        }


        protected void DropDownTipo()
        {

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:5000/api/v1/presente/tipo");
            request.Method = "GET";
            //request.Method = "POST";
            //request.ContentType = "application/json; charset=utf-8";
            //request.Headers.Add("token", "xxxxxxxxxxxxxxxxxx");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(0));

            string result = streamReader.ReadLine();

            List<PresenteTipoEntity> listaTipo = ConverteJSonParaObject<List<PresenteTipoEntity>>(result);
            int i = 0;
            foreach (var tipo in listaTipo)
            {
                DdwTipoPresente.Items.Insert(i, tipo.descTipo);
                i++;
            }

        }

        protected void DropDownMarca()
        {

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:5000/api/v1/presente/marca");
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(0));

            string result = streamReader.ReadLine();

            List<PresenteMarcaEntity> listaMarca = ConverteJSonParaObject<List<PresenteMarcaEntity>>(result);
            int i = 0;
            foreach (var marca in listaMarca)
            {
                DdwMarca.Items.Insert(i, marca.marcaDesc);
                i++;
            }

        }

        protected void DropDownFinalidade()
        {

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:5000/api/v1/presente/finalidade");
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(0));

            string result = streamReader.ReadLine();

            List<PresenteFinalidadeEntity> listaFinalidade = ConverteJSonParaObject<List<PresenteFinalidadeEntity>>(result);
            int i = 0;
            foreach (var finalidade in listaFinalidade)
            {
                DdwFinalidade.Items.Insert(i, finalidade.descFinalidade);
                i++;
            }

        }

        protected void DropDownFornecedor()
        {

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:5000/api/v1/presente/fornecedor");
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(0));

            string result = streamReader.ReadLine();

            listaFornecedor = ConverteJSonParaObject<List<PresenteFornecedorEntity>>(result);
            int i = 0;
            foreach (var forn in listaFornecedor)
            {
                DdwFornecedor.Items.Insert(i, forn.nomeFornecedor);
                i++;
            }

        }

        protected void TabelaPresente()
        {

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:5000/api/v1/presente/presente");
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(0));

            string result = streamReader.ReadLine();

            List<PresenteEntity> listaPresente = ConverteJSonParaObject<List<PresenteEntity>>(result);

            GVPresentes.DataSource = listaPresente;
            GVPresentes.DataBind();

        }

        protected async Task CadPresenteAsync(PresenteEntity presente) 
        {
            //var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:5000/api/v1/presente/cadPresente");
            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Method = "POST";
            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    var json = new JavaScriptSerializer().Serialize(presente);
            //    streamWriter.Write(json);
            //}
            var json = new JavaScriptSerializer().Serialize(presente);
            //    streamWriter.Write(json);

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                    "http://localhost:5000/api/v1/presente/cadPresente",
                     new StringContent(json, Encoding.UTF8, "application/json"));
            }

        }



        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            PresenteEntity presente = new PresenteEntity();

            presente.codPresente = 0;
            presente.descPresente = TxtPresente.Text;
            presente.codTipo = 1;
            presente.codMarca = 2;
            presente.codFinalidade = 2;
            presente.corPresente = "VERMELHO";
            presente.tamanhoPresente = DdwTamanhoPresente.SelectedValue;
            presente.precoPresente = double.Parse(TxtPreco.Text);
            presente.codFornecedor = 10281;
            presente.nomeFornecedor = "CARROS SA";
            presente.descMarca = "HONDA";
            presente.descTipo = "VEICULO";
            presente.descFinalidade = "NATAL";



            //var json = new JavaScriptSerializer().Serialize(presente);
            //TxtPreco.Text = json;




            CadPresenteAsync(presente);

            TabelaPresente();



            //PresenteFornecedorEntity forn;
            //forn = listaFornecedor[0];

            //Grava g = new Grava();

            //TxtPreco.Text = g.GravaPresente(forn, 1);
            //TxtPreco.Text = DdwFornecedor.SelectedIndex.ToString();
            //TxtPreco.Text = listaFornecedor[0].codFornecedor.ToString();
        }
    }
}