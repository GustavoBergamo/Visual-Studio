using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimVII
{
    internal class CarrinhoRepository
    {


//Criando as classes do Pim
        public class pessoa
        {
            public int id { get; set; }
            public string email { get; set; }
            public string senha { get; set; }
        }
        public class cliente : pessoa
        {
            public string nome { get; set; }
            public string cpf { get; set; }
            public int endereco_id { get; set; }
        }
        public class vendedor : pessoa
        {
            public string razao_social { get; set; }
            public string nome_fantasia { get; set; }
            public string cnpj { get; set; }
            public float comissao { get; set; }
            public int endereco_id { get; set; }
        }
        public class produto
        {
            public int id { get; set; }
            public string descricao { get; set; }
            public float preco { get; set; }
            public string imagem { get; set; }
            public bool status { get; set; }
            public int vendedor_id { get; set; }
            public int categoria_id { get; set; }
        }
        public class carrinho
        {
            public int id { get; set; }
            public string data_pedido { get; set; }
            public string valor_total { get; set; }
            public string cliente_id { get; set; }
            public string produtos { get; set; }
        }
        public class item_carrinho
        {
            public string quantidade { get; set; }
            public float total { get; set; }
            public int carrinho_id { get; set; }
            public int produto_id { get; set; }
        }
 //Criando metodo Conector
public class Conector
{
    private static SQLiteConnection SQLiteConnection;
    public Conector()
    { }

    private static SQLiteConnection DbConnection()
    {
        SQLiteConnection = new SQLiteConnection("Data Source=Pim.db");
//como a conexao pode ser fechada 2 vezes mas nao aberta 2 vezes
//fecha-se primeiro para em seguida abri-la
        SQLiteConnection.Close();
        SQLiteConnection.Open();
        return SQLiteConnection;
    }

//Criando metodo Desconector
    public void Desconector(SQLiteConnection conn)
    {
        if (conn.State == System.Data.ConnectionState.Open)
        {
            conn.Close();
        }
    }

//Criando metodo para adicionar ao carrinho
    public static void Adicionar(carrinho carrinho)
    {
        try
        {
            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO carrinho(data_pedido, valor_total, cliente_id, produtos) values (@data_pedido, @valor_total, @cliente_id, @produtos)";
                cmd.Parameters.AddWithValue("@data_pedido", carrinho.data_pedido);
                cmd.Parameters.AddWithValue("@valor_total", carrinho.valor_total);
                cmd.Parameters.AddWithValue("@cliente_id", carrinho.cliente_id);
                cmd.Parameters.AddWithValue("@produtos", carrinho.produtos);
                cmd.ExecuteNonQuery();
            }
            SQLiteConnection.Close();
        }
        catch (Exception ex) {
            throw ex;
        }
    }

//Criando metodo para atualizar dados do carrinho
    public static void Atualizar(carrinho carrinho)
    {
        try
        {
            using (var cmd = new SQLiteCommand(DbConnection()))
            {
                if(carrinho.id != null)
                {
                    cmd.CommandText = "UPDATE carrinho SET  valor_total=@valor_total, produtos=@produtos WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", carrinho.id);
                    cmd.Parameters.AddWithValue("@valor_total", carrinho.valor_total);
                    cmd.Parameters.AddWithValue("@produtos", carrinho.produtos);
                    cmd.ExecuteNonQuery();
                }
                SQLiteConnection.Close();
            }
        }
        catch (Exception ex) 
        {
            throw ex;
        }
    }

//criando metodo para excluir dados do carrinho
    public static void Excluir(carrinho carrinho)
    {
        try
        {
            using (var cmd = new SQLiteCommand(DbConnection()))
            {
                cmd.CommandText = "DELETE FROM carrinho WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", carrinho.id);
                cmd.ExecuteNonQuery();
            }
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

//Criando metodo para obter carrinho por id
    public static DataTable ObterPorId(int id)
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM carrinho WHERE id = " + id;
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

//Criando metodo para obter todos
    public static DataTable Obtertodos()
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
}
