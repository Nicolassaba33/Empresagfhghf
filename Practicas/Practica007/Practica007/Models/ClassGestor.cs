using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml;

namespace Practica007.Models
{
    public class ClassGestor
    {
        private const string StrConn = "Server=DESKTOP-KLJUTM1\\MSSQLSERVER01;Database=Practica;User Id=sa;Password=Globolixo;";

        

        public List<Legajo> ObtenerLegajos()
        {
            List<Legajo> lista = new List<Legajo>();

            SqlConnection conn = new SqlConnection(StrConn);
            conn.Open();

            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM Legajo";

            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                int NUMEROLEGAJO = dr.GetInt32(0);
                int DNI = dr.GetInt32(1);
                string APELLIDONOMBRE = dr.GetString(2);
                string FECHADECARGA = dr.GetString(3);
                


                Legajo l = new Legajo(NUMEROLEGAJO, DNI, APELLIDONOMBRE, FECHADECARGA);
                lista.Add(l);
            }

            dr.Close();
            conn.Close();

            return lista;
        }

       
        
    }
}