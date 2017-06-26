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
        public static void criaReserva(string id_reserva, string data_entrada, string data_saida, int n_pessoas, int numeroQuarto)
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
                    sb.Append("INSERT INTO reserva ([id], [data_entrada], [data_saida], [n_pessoas]) ");
                    sb.Append("VALUES (@id, @data_entrada, @data_saida, @n_pessoas);");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id_reserva);
                        command.Parameters.AddWithValue("@data_entrada", data_entrada);
                        command.Parameters.AddWithValue("@data_saida", data_saida);
                        command.Parameters.AddWithValue("@n_pessoas", n_pessoas);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    StringBuilder sb2 = new StringBuilder();
                    sb2.Append("UPDATE quarto SET status = 'reservado' WHERE status = 'vago' AND numero = @numero;");
                    sql = sb2.ToString();
                    using (SqlCommand comando = new SqlCommand(sql, connection))
                    {
                        comando.Parameters.AddWithValue("@numero", numeroQuarto);
                        int rowsAffected = comando.ExecuteNonQuery();
                        Console.WriteLine(rowsAffected + " row(s) updated");
                    }

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void criaHospede(string id_reserva, string nome, string cpf, string login, string senha, string sexo, string email, int idade, string telefone, string endereco, string cep, string cidade, string estado)
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
                    sb.Append("INSERT INTO hospede ");
                    sb.Append("VALUES (@nome, @cpf, @login, @senha, @sexo, @email, @idade, @telefone, @endereco, @cep, @cidade, @estado, @id_reserva);");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id_reserva", id_reserva);
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@cpf", cpf);
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@senha", senha);
                        command.Parameters.AddWithValue("@sexo", sexo);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@idade", idade);
                        command.Parameters.AddWithValue("@telefone", telefone);
                        command.Parameters.AddWithValue("@endereco", endereco);
                        command.Parameters.AddWithValue("@cep", cep);
                        command.Parameters.AddWithValue("@cidade", cidade);
                        command.Parameters.AddWithValue("@estado", estado);
                        Console.WriteLine("O comando é: ");
                        Console.WriteLine(command.CommandText);
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


                    // Cria um funcionário
                    sb.Append("INSERT INTO funcionario ([nome], [cpf], [login], [senha]) ");
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

                    // Cria um cargo e atribui ao funcionário
                    if (cargo == "administrador")
                    {
                        StringBuilder sb2 = new StringBuilder();
                        sb2.Append("INSERT INTO administrador ([cpf]) ");
                        sb2.Append("VALUES (@cpf);");
                        sql = sb2.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@cpf", cpf);
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                    else if (cargo == "camarista")
                    {
                        StringBuilder sb2 = new StringBuilder();
                        sb2.Append("INSERT INTO camarista ([cpf]) ");
                        sb2.Append("VALUES (@cpf);");
                        sql = sb2.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@cpf", cpf);
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                    else if (cargo == "recepcionista")
                    {
                        StringBuilder sb2 = new StringBuilder();
                        sb2.Append("INSERT INTO recepcionista ([cpf]) ");
                        sb2.Append("VALUES (@cpf);");
                        sql = sb2.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@cpf", cpf);
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static string checkIn(int numeroQuarto)
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
                    sb.Append("UPDATE Quarto ");
                    sb.Append("SET status = 'ocupado' ");
                    sb.Append("WHERE status = 'reservado' AND numero = @numero;");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@numero", numeroQuarto);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine(rowsAffected + " row(s) updated");
                    }
                    return numeroQuarto.ToString();

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return "Erro";
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
                        sb.Append("SELECT h.login ");
                        sb.Append("FROM hospede h ");
                        sb.Append("WHERE h.login = @login and h.senha = @senha;");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@login", login);
                            command.Parameters.AddWithValue("@senha", senha);

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
                                return false;
                            }
                        }
                    }
                    else if (tabela == "recepcionista")
                    {
                        sb.Append("SELECT f.login ");
                        sb.Append("FROM Funcionario f JOIN Recepcionista r ON f.cpf = r.cpf ");
                        sb.Append("WHERE f.login = @login and f.senha = @senha;");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@login", login);
                            command.Parameters.AddWithValue("@senha", senha);

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
                                return false;
                            }
                        }
                    }
                    else if (tabela == "administrador")
                    {
                        sb.Append("SELECT f.login ");
                        sb.Append("FROM Funcionario f JOIN administrador r ON f.cpf = r.cpf ");
                        sb.Append("WHERE f.login = @login and f.senha = @senha;");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@login", login);
                            command.Parameters.AddWithValue("@senha", senha);

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
                                return false;
                            }
                        }
                    }
                    else if (tabela == "camarista")
                    {
                        sb.Append("SELECT f.login ");
                        sb.Append("FROM Funcionario f JOIN camarista r ON f.cpf = r.cpf ");
                        sb.Append("WHERE f.login = @login and f.senha = @senha;");
                        sql = sb.ToString();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@login", login);
                            command.Parameters.AddWithValue("@senha", senha);

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
                                return false;
                            }
                        }
                    }
                    else
                        return false;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        public static List<String> carregaQuartosVagos()
        {
            List<String> erro = new List<string> { "Erro" };
            List<String> quartosVagos = new List<string> { };
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

                    sb.Append("SELECT numero ");
                    sb.Append("FROM quarto  ");
                    sb.Append("WHERE status = 'vago';");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        Console.WriteLine("A consulta é: ");
                        Console.WriteLine(command.CommandText);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                quartosVagos.Add(reader.GetInt32(0).ToString());
                            }
                            return quartosVagos;
                        }
                    }
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return erro;
            }
        }
            public static void deletaReserva(int numeroQuarto)
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
                    sb.Append("UPDATE Quarto ");
                    sb.Append("SET status = 'vago' ");
                    sb.Append("WHERE status = 'reservado' AND numero = @numero;");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@numero", numeroQuarto);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine(rowsAffected + " row(s) updated");
                    }
                    return;

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return;
            }
        }
        public static void checkOut(int numeroQuarto)
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
                    sb.Append("UPDATE Quarto ");
                    sb.Append("SET status = 'vago' ");
                    sb.Append("WHERE status = 'ocupado' AND numero = @numero;");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@numero", numeroQuarto);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine(rowsAffected + " row(s) updated");
                    }
                    return;

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return;
            }
        }

    }
}
