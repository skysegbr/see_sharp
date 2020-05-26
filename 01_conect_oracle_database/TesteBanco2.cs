
using System;
using System.Data;
using System.Data.Common;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace _01_conect_oracle_database
{

    class TesteBanco2
    {
        static void GetCursorFunction(OracleConnection con)
        {
            // display a simple marker line to the console
            // to indicate where we are
            Console.WriteLine("In GetCursorFunction...");
            Console.WriteLine();

            // create the command object and set attributes
            OracleCommand cmd = new OracleCommand("otn_ref_cursor.get_emp_info", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // create parameter object for the cursor
            OracleParameter p_refcursor = new OracleParameter();

            // this is vital to set when using ref cursors
            p_refcursor.OracleDbType = OracleDbType.RefCursor;

            // this is a function return value so we must indicate that fact
            p_refcursor.Direction = ParameterDirection.ReturnValue;

            // add the parameter to the collection
            cmd.Parameters.Add(p_refcursor);

            // create a data adapter to use with the data set
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            // create the data set
            DataSet ds = new DataSet();

            // fill the data set
            da.Fill(ds);

            // display the data to the console window
            //DisplayRefCursorData(ds);

            // clean up our objects release resources
            ds.Dispose();
            da.Dispose();
            p_refcursor.Dispose();
            cmd.Dispose();

            Console.WriteLine();
        }
        //------------------------

        static void TraverseResultSets(OracleConnection con)
        {
            // display a simple marker line to the console
            // to indicate where we are
            Console.WriteLine("In TraverseResultSets...");
            Console.WriteLine();

            // create the command object and set attributes
            OracleCommand cmd = new OracleCommand("otn_ref_cursor.get_multiple_cursors", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // create parameter objects for the cursors
            OracleParameter p_rc1 = new OracleParameter();
            OracleParameter p_rc2 = new OracleParameter();
            OracleParameter p_rc3 = new OracleParameter();

            // this is vital to set when using ref cursors
            p_rc1.OracleDbType = OracleDbType.RefCursor;
            p_rc2.OracleDbType = OracleDbType.RefCursor;
            p_rc3.OracleDbType = OracleDbType.RefCursor;

            // these are output parameters so we must indicate that fact
            p_rc1.Direction = ParameterDirection.Output;
            p_rc2.Direction = ParameterDirection.Output;
            p_rc3.Direction = ParameterDirection.Output;

            // add the parameters to the collection
            cmd.Parameters.Add(p_rc1);
            cmd.Parameters.Add(p_rc2);
            cmd.Parameters.Add(p_rc3);

            // work with an OracleDataReader rather
            // than a DataSet to illustrate ODP.NET features
            OracleDataReader dr = cmd.ExecuteReader();

            // display the data in the first ref cursor
            Console.WriteLine("Displaying ref cursor #1:");
            //DisplayRefCursorData(dr);
            Console.WriteLine();

            // the Oracle Data Provider follows the standard
            // by exposing the NextResult method to traverse
            // multiple result sets

            // display the data in the second ref cursor
            if (dr.NextResult())
            {
                Console.WriteLine("Displaying ref cursor #2:");
                //DisplayRefCursorData(dr);
                Console.WriteLine();
            }

            // display the data in the third ref cursor
            if (dr.NextResult())
            {
                Console.WriteLine("Displaying ref cursor #3:");
                //DisplayRefCursorData(dr);
                Console.WriteLine();
            }

            // clean up our objects and release resources
            dr.Dispose();
            p_rc1.Dispose();
            p_rc2.Dispose();
            p_rc3.Dispose();
            cmd.Dispose();
        }
        //------------------------


        static void MultipleActiveResultSets(OracleConnection con)
        {
            // display a simple marker line to the console
            // to indicate where we are
            Console.WriteLine("In MultipleActiveResultSets...");
            Console.WriteLine();

            // create the command object and set attributes
            OracleCommand cmd = new OracleCommand("otn_ref_cursor.get_multiple_cursors", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // create parameter objects for the cursors
            OracleParameter p_rc1 = new OracleParameter();
            OracleParameter p_rc2 = new OracleParameter();
            OracleParameter p_rc3 = new OracleParameter();

            // this is vital to set when using ref cursors
            p_rc1.OracleDbType = OracleDbType.RefCursor;
            p_rc2.OracleDbType = OracleDbType.RefCursor;
            p_rc3.OracleDbType = OracleDbType.RefCursor;

            // these are output parameters so we must indicate that fact
            p_rc1.Direction = ParameterDirection.Output;
            p_rc2.Direction = ParameterDirection.Output;
            p_rc3.Direction = ParameterDirection.Output;

            // add the parameters to the collection
            cmd.Parameters.Add(p_rc1);
            cmd.Parameters.Add(p_rc2);
            cmd.Parameters.Add(p_rc3);

            // execute the command to open the ref cursors
            cmd.ExecuteNonQuery();

            // work with an OracleDataReader rather
            // than a DataSet to illustrate ODP.NET features
            OracleDataReader dr1 = ((OracleRefCursor)p_rc1.Value).GetDataReader();

            // notice we are skipping the second (or "middle") ref cursor
            OracleDataReader dr3 = ((OracleRefCursor)p_rc3.Value).GetDataReader();

            // illustrate the multiple result sets are active
            // by "randomly" displaying data from each one
            if (dr1.Read())
            {
                Console.WriteLine("Displaying data from ref cursor #1:");
                //DisplayDataReaderRow(dr1);
                Console.WriteLine();
            }

            if (dr3.Read())
            {
                Console.WriteLine("Displaying data from ref cursor #3:");
                //DisplayDataReaderRow(dr3);
                Console.WriteLine();
            }

            if (dr1.Read())
            {
                Console.WriteLine("Displaying data from ref cursor #1:");
                //DisplayDataReaderRow(dr1);
                Console.WriteLine();
            }

            if (dr3.Read())
            {
                Console.WriteLine("Displaying data from ref cursor #3:");
                //DisplayDataReaderRow(dr3);
                Console.WriteLine();
            }

            // clean up our objects and release resources
            dr1.Dispose();
            dr3.Dispose();
            p_rc1.Dispose();
            p_rc2.Dispose();
            p_rc3.Dispose();
            cmd.Dispose();
        }


        //-------------------------------------
        static void GetCursorParameter(OracleConnection con)
        {
            // display a simple marker line to the console
            // to indicate where we are
            Console.WriteLine("In GetCursorParameter...");
            Console.WriteLine();

            // create the command object and set attributes
            OracleCommand cmd = new OracleCommand("AUTORIZADOR_REGRAS.RET_PLAS", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // create parameter object for the cursor
            OracleParameter p_plas = new OracleParameter();

            // this is vital to set when using ref cursors
            p_plas.OracleDbType = OracleDbType.RefCursor;

            // this is an output parameter so we must indicate that fact
            p_plas.Direction = ParameterDirection.Output;

            // add the parameter to the collection
            cmd.Parameters.Add("P_COD_PLAS", OracleDbType.Int16).Value = 0;
            cmd.Parameters.Add("P_NOME_PLAS", OracleDbType.Varchar2).Value = "sulamerica";
            cmd.Parameters.Add(p_plas);
            OracleDataReader reader;
            reader = cmd.ExecuteReader();

            foreach (DbDataRecord s in reader)
            {
                int val = s.GetInt32(0);
                Console.WriteLine(val);
                Int64 val1 = s.GetInt64(1);
                Console.WriteLine(val1);
                String val2 = s.GetString(2);
                Console.WriteLine(val2);
                // var plano = new PlanoSaudeEntity();
                // plano.NomePlas = s.GetString(0);
                // list.Add(plano);
            }




            // create a data adapter to use with the data set
            // OracleDataAdapter da = new OracleDataAdapter(cmd);

            // // create the data set
            // DataSet ds = new DataSet();

            // // fill the data set
            // da.Fill(ds);
            // foreach (DataTable table in ds.Tables)
            // {
            //     foreach (DataRow row in table.Rows)
            //     {
            //         foreach (object item in row.ItemArray)
            //         {
            //             Console.WriteLine(item);
            //         }
            //     }
            // }

            // display the data to the console window
            //DisplayRefCursorData(ds);

            // clean up our objects release resources
            //ds.Dispose();
            //da.Dispose();
            p_plas.Dispose();
            cmd.Dispose();

            Console.WriteLine();
        }
        //----------------------

        static void Main(string[] args)
        {
            OracleConnection con = new OracleConnection("User Id=C##tux;Password=tux;Data Source=localhost:1521/ORCLCDB");

            try
            {
                con.Open();
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (con.State == ConnectionState.Open)
            {
                // call method that gets a ref cursor from pl/sql function
                //GetCursorFunction(con);

                // call method that gets a ref cursor from pl/sql procedure
                GetCursorParameter(con);

                // call method that serially traverses multiple result sets
                //TraverseResultSets(con);

                // call method that illustrates multiple active result sets (MARS)
                //MultipleActiveResultSets(con);
            }

        }

    }

}