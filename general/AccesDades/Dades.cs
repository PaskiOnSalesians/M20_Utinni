using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesDades
{
    public class Dades
    {
        SqlConnection cns;
        SqlDataAdapter adapter;
        DataSet dts;
        //string query;

        public void ConnectDB()
        {
            string cadena = "", connexio;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["MESSIServer"];

            if (settings != null)
            {
                cadena = settings.ConnectionString.ToString();
            }

            connexio = cadena;

            cns = new SqlConnection(connexio);
            cns.Open();
        }

        public DataSet QueryDB(string query)
        {
            //ConnectDB();
            //DataSet dataSet = new DataSet();
            //new SqlDataAdapter(query, con).Fill(dataSet, nomtaula);
            //return dataSet;

            adapter = new SqlDataAdapter(query, cns);

            dts = new DataSet();
            adapter.Fill(dts, "AdminCoordinates");

            return dts;
        }
    }
}
