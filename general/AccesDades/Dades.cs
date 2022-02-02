using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public DataSet QueryDB(string query, string taula)
        {
            //ConnectDB();
            //DataSet dataSet = new DataSet();
            //new SqlDataAdapter(query, con).Fill(dataSet, nomtaula);
            //return dataSet;

            adapter = new SqlDataAdapter(query, cns);

            dts = new DataSet();
            adapter.Fill(dts, taula);

            return dts;
        }

        public void Actualitzar(string query, string taula, DataSet _dts)
        {
            int numReg;

            ConnectDB();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cns);
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adapter);

            if (_dts.HasChanges())
            {
                numReg = adapter.Update(_dts, taula);
                MessageBox.Show("Registres modificats: " + numReg.ToString());
            }

            if (cns != null)
            {
                cns.Close();
                cns.Dispose();
            }
        }
    }
}
