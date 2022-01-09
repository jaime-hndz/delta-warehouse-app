using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; using System.Data.SqlServerCe;

namespace Login_Cnumeral
{
    public class utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlCeConnection conex = new SqlCeConnection("Data Source=|DataDirectory|\\ALMACEN.sdf");
            conex.Open();

            DataSet DS = new DataSet();
            SqlCeDataAdapter DP = new SqlCeDataAdapter(cmd, conex);

            DP.Fill(DS);

            conex.Close();

            return DS;
            
        }
  



    }
}
