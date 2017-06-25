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
        public static void criaReserva(string id_reserva, string data_entrada, string data_saida, int n_pessoas)
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
                    sb.Append("INSERT INTO @reserva ([id_reserva], [data_entrada], [data_saida], [n_pessoas]) ");
                    sb.Append("VALUES (@nome, @cpf, @login, @senha);");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id_reserva", id_reserva);
                        command.Parameters.AddWithValue("@data_entrada", data_entrada);
                        command.Parameters.AddWithValue("@data_saida", data_saida);
                        command.Parameters.AddWithValue("@n_pessoas", n_pessoas);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void criaHospede(string id_reserva, string nome, string cpf, int idade, string email)
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

                    sb.Append("INSERT INTO hospede ([id_reserva], [nome], [cpf], [idade], [email]) ");
                    sb.Append("VALUES (@id_reserva, @nome, @cpf, @idade, @email);");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@cpf", cpf);
                        command.Parameters.AddWithValue("@idade", idade);
                        command.Parameters.AddWithValue("@email", email);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void criaFuncionario(string nome, string cpf, string login, string senha, string cargo)
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

                    sb.Append("INSERT INTO @cargo ([nome], [cpf], [login], [senha]) ");
                    sb.Append("VALUES (@nome, @cpf, @login, @senha);");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@cargo", cargo);
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@cpf", cpf);
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@senha", senha);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
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
                    String sql;
                    if (tabela == "hospede")
                    {
                        sb.Append("SELECT login");
                        sb.Append("FROM [Hospede]");
                        sb.Append("WHERE login == @login;");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@login", login);
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        sb.Append("SELECT login");
                        sb.Append("FROM [funcionario]");
                        sb.Append("WHERE login == @login;");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@login", login);
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
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
                    String sql;
                    if (tabela == "hospede")
                    {
                        sb.Append("SELECT senha");
                        sb.Append("FROM [Hospede]");
                        sb.Append("WHERE senha == @senha;");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@senha", senha);
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        sb.Append("SELECT senha");
                        sb.Append("FROM [funcionario]");
                        sb.Append("WHERE senha == @senha;");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@senha", senha);
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
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
                    String sql;
                    if (tabela == "hospede")
                    {
                        sb.Append("SELECT cpf");
                        sb.Append("FROM [Hospede]");
                        sb.Append("WHERE cpf = @cpf;");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@cpf", cpf);
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        sb.Append("SELECT cpf");
                        sb.Append("FROM [funcionario]");
                        sb.Append("WHERE cpf = @cpf;");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@cpf", cpf);
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
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
                    String sql;
                    //Não mexi no caso do hospede. Arrumar aqui
                    if (tabela == "hospede")
                    {
                        sb.Append("SELECT login");
                        sb.Append("FROM [Hospede]");
                        sb.Append("WHERE login = @login AND senha = @senha");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            SqlParameter param = new SqlParameter();
                            param.ParameterName = "@Login";
                            param.Value = login;
                            command.Parameters.Add(param);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                return false;
                                //if (!reader.IsDBNull(0))
                                //    return reader.GetString(0);
                               // return string.Empty;
                            }
                        }
                    }
                    else //mexi aqui
                    {
                        sb.Append("SELECT login ");
                        sb.Append("FROM Funcionario ");
                        sb.Append("WHERE login = @login and senha = @senha;");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@login", login);
                            command.Parameters.AddWithValue("@senha", senha);


                            //SqlParameter param = new SqlParameter();
                            //param.ParameterName = "@login";
                            //param.Value = "admin";
                            //command.Parameters.Add(param);
                            Console.WriteLine("A consulta é: ");
                            Console.WriteLine(command.CommandText);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine("{0}", reader.GetString(0));
                                    if (!reader.IsDBNull(reader.GetOrdinal("login"))) //Isso tem q estar dentro desse while!!!!!!
                                    {
                                        return true;
                                    }
                                }
                                //if (!reader.IsDBNull(0))
                                //    return reader.GetString(0);
                                //return string.Empty;
                                return false;
                            }
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
        public static void deletaReserva(string cpf)
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
                    sb.Append("DELETE FROM hospede WHERE cpf = @cpf;");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@cpf", cpf );
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine(rowsAffected + " row(s) deleted");
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
