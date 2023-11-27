using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.Common;

namespace PimVII
{ }
/* public class Conector
 {
     private static SQLiteConnection SQLiteConnection;
     public Conector()
     { }

     private static SQLiteConnection DbConnection()
     {  
         SQLiteConnection = new SQLiteConnection("Data Source=Pim.db");
como a conexao pode ser fechada 2 vezes mas nao aberta 2 vezes
fecha-se primeiro para em seguida abri-la
         SQLiteConnection.Close();
         SQLiteConnection.Open();
         return SQLiteConnection;
     }


     //
     public static DataTable GetCarrinho()
     {
         SQLiteDataAdapter da = null;
         DataTable dt = new DataTable();
         try
         {
             using (var cmd = DbConnection().CreateCommand())
             {
                 cmd.CommandText = "SELECT * FROM carrinho";
                 da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                 da.Fill(dt);
                 return dt;
             }
         }
         catch (Exception ex)
         {
             throw ex;
         }

     }
 }
}
*/