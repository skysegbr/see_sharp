using DBUtil;
using Oracle.DataAccess.Client;
using System;
using System.Data.Common;

namespace Testes
{
    public class Testes
    {
        static void Main()
        {
            OracleDataReader reader;
            reader = DBConnection.Execute("SELECT * FROM TB_PLANO_SAUDE");

            foreach (DbDataRecord s in reader)
            {
                string val = s.GetString(0);
                Console.WriteLine(val);
            }
        }
    }
}
