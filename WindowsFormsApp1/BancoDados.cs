using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class BancoDados
    {
        /*public static void conecta()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                builder.DataSource = "laudebankolino.database.windows.net"; 
                builder.UserID = "thico10";            
                builder.Password = "LuThiWill9264";     
                builder.InitialCatalog = "laudebanks";
                connection.Open();
                Console.WriteLine("Conectei :)");
            }
            catch (Exception e)
            {
                throw e;
            }
        }*/
        public BancoDados(string nomeArq)
        {
            try
            {

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void create()
        {
            try
            {

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void read()
        {
            try
            {

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void write()
        {
        }
        public void erase()
        {
        }
        public static void setCPF(string cpf, string tabela)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "laudebankolino.database.windows.net";
                builder.UserID = "thico10";
                builder.Password = "LuThiWill9264";
                builder.InitialCatalog = "laudebanks";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    if (tabela == "hospede")
                    {
                        sb.Append("INSERT INTO Hospede ([cpf])");
                        sb.Append("VALUES (@cpf)");
                    }
                    else
                    {
                        sb.Append("INSERT INTO Funcionario ([cpf])");
                        sb.Append("VALUES (@cpf)");
                    }
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            command.Parameters.AddWithValue("@cpf", cpf);
                            int rowsAffected = command.ExecuteNonQuery();
                            Console.WriteLine(rowsAffected + " row(s) inserted");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void setNome(string nome, string tabela)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "laudebankolino.database.windows.net";
                builder.UserID = "thico10";
                builder.Password = "LuThiWill9264";
                builder.InitialCatalog = "laudebanks";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    if (tabela == "hospede")
                    {
                        sb.Append("INSERT INTO Hospede ([nome])");
                        sb.Append("VALUES (@nome)");
                    }
                    else
                    {
                        sb.Append("INSERT INTO Funcionario ([nome])");
                        sb.Append("VALUES (@nome)");
                    }
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            command.Parameters.AddWithValue("@nome", nome);
                            int rowsAffected = command.ExecuteNonQuery();
                            Console.WriteLine(rowsAffected + " row(s) inserted");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void setSenha(string senha, string tabela)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "laudebankolino.database.windows.net";
                builder.UserID = "thico10";
                builder.Password = "LuThiWill9264";
                builder.InitialCatalog = "laudebanks";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    if (tabela == "hospede")
                    {
                        sb.Append("INSERT INTO Hospede ([senha])");
                        sb.Append("VALUES (@senha)");
                    }
                    else
                    {
                        sb.Append("INSERT INTO Funcionario ([senha])");
                        sb.Append("VALUES (@senha)");
                    }
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            command.Parameters.AddWithValue("@senha", senha);
                            int rowsAffected = command.ExecuteNonQuery();
                            Console.WriteLine(rowsAffected + " row(s) inserted");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void setLogin(string login, string tabela)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "laudebankolino.database.windows.net";
                builder.UserID = "thico10";
                builder.Password = "LuThiWill9264";
                builder.InitialCatalog = "laudebanks";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    if (tabela == "hospede")
                    {
                        sb.Append("INSERT INTO Hospede ([login])");
                        sb.Append("VALUES (@login)");
                    }
                    else
                    {
                        sb.Append("INSERT INTO Funcionario ([login])");
                        sb.Append("VALUES (@login)");
                    }
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            command.Parameters.AddWithValue("@login", login);
                            int rowsAffected = command.ExecuteNonQuery();
                            Console.WriteLine(rowsAffected + " row(s) inserted");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public string getLogin(string[] login, string tabela)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "laudebankolino.database.windows.net";
                builder.UserID = "thico10";
                builder.Password = "LuThiWill9264";
                builder.InitialCatalog = "laudebanks";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    if (tabela == "hospede")
                    {
                        sb.Append("SELECT login");
                        sb.Append("FROM [Hospede]");
                        sb.Append("WHERE login == @login;");
                    }
                    else
                    {
                        sb.Append("SELECT login");
                        sb.Append("FROM [funcionario]");
                        sb.Append("WHERE login == @login;");
                    }
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.GetString(0);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return "DeuRuimNoSantander";
            }
        }
        public string getSenha(string[] senha, string tabela)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "laudebankolino.database.windows.net";
                builder.UserID = "thico10";
                builder.Password = "LuThiWill9264";
                builder.InitialCatalog = "laudebanks";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    if (tabela == "hospede")
                    {
                        sb.Append("SELECT senha");
                        sb.Append("FROM [Hospede]");
                        sb.Append("WHERE senha == @senha;");
                    }
                    else
                    {
                        sb.Append("SELECT senha");
                        sb.Append("FROM [funcionario]");
                        sb.Append("WHERE senha == @senha;");
                    }
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.GetString(0);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return "DeuRuimNoSantander";
            }
        }
        public string getCpf(string[] cpf, string tabela)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "laudebankolino.database.windows.net";
                builder.UserID = "thico10";
                builder.Password = "LuThiWill9264";
                builder.InitialCatalog = "laudebanks";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    if (tabela == "hospede")
                    {
                        sb.Append("SELECT cpf");
                        sb.Append("FROM [Hospede]");
                        sb.Append("WHERE cpf == @cpf;");
                    }
                    else
                    {
                        sb.Append("SELECT cpf");
                        sb.Append("FROM [funcionario]");
                        sb.Append("WHERE cpf == @cpf;");
                    }
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.GetString(0);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return "DeuRuimNoSantander";
            }
        }
        public static bool efetuarLogin(string login, string senha, string tabela)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "laudebankolino.database.windows.net";
                builder.UserID = "thico10";
                builder.Password = "LuThiWill9264";
                builder.InitialCatalog = "laudebanks";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    if (tabela == "hospede")
                    {
                        sb.Append("SELECT login");
                        sb.Append("FROM [Hospede]");
                        sb.Append("WHERE login == @login AND senha == @senha");
                    }
                    else
                    {
                        sb.Append("SELECT login");
                        sb.Append("FROM [funcionario]");
                        sb.Append("WHERE login == @login AND senha == @senha");
                    }
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (string.IsNullOrEmpty(reader.GetString(0)))
                                return false;
                            else
                                return true;
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
