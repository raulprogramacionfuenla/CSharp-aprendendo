using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_20151013_conexao_ADO {
    class Program {
        static void Main(string[] args) {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=csharp;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Id, Nome from Categoria", conn);
            
            SqlDataReader r = cmd.EndExecuteReader();

            while (r.Read()) {
                Console.WriteLine("Categoria: {0}", r["Nome"].ToString());
            }
            conn.Close();
        }
    }
}
