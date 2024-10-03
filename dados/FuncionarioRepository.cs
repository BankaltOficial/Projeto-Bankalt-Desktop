using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dados
{
    public class FuncionarioRepository
    {
        // insert na tabela funcionarioslogin //


        private string connectionstr = "Server=143.106.241.4;Database=cl203231;User ID=cl203231;Password=cl*25122007;";

        public void insertfuncionariologin(Funcionario funcionario)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionstr);
                string query = "INSERT INTO funcionariologin (Senha, Username) VALUES (?, ?)";
                var insert = new MySqlCommand(query, connection);

                insert.Parameters.AddWithValue("1", funcionario.Senha);
                insert.Parameters.AddWithValue("2", funcionario.Username);

                connection.Open();
                insert.ExecuteNonQuery();
                connection.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        // insert na tabela funcionarios dados só 1ª tela //
        public void InsertFuncionario(Funcionario funcionario)
        {
            string query = "INSERT INTO funcionariodados (Nome, Cpf, Usuario, Senha, Rg, DataNascimento, Cargo, Estadocivil, Pais, Estado, Cidade, Bairro, Rua, Cep, Numero, Complemento, ContatoEmergencia, Celular, Telefone, Email, Salario) " +
                           "VALUES (@Nome, @Cpf, @Usuario, @Senha, @Rg, @DataNascimento, @Cargo, @EstadoCivil, @Pais, @Estado, @Cidade, @Bairro, @Rua, @Cep, @Numero, @Complemento, @ContatoEmergencia, @Celular, @Telefone, @Email, @Salario)";

            using (MySqlConnection connection = new MySqlConnection(connectionstr))
            {
                using (MySqlCommand insert = new MySqlCommand(query, connection))
                {
                    insert.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    insert.Parameters.AddWithValue("@Cpf", funcionario.Cpf);
                    insert.Parameters.AddWithValue("@Usuario", funcionario.Username);
                    insert.Parameters.AddWithValue("@Senha", funcionario.Senha);
                    insert.Parameters.AddWithValue("@Rg", funcionario.Rg);
                    insert.Parameters.AddWithValue("@DataNascimento", funcionario.Datanascimento);
                    insert.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    insert.Parameters.AddWithValue("@Estadocivil", funcionario.Estadocivil);
                    insert.Parameters.AddWithValue("@Pais", funcionario.Pais);
                    insert.Parameters.AddWithValue("@Estado", funcionario.Estado);
                    insert.Parameters.AddWithValue("@Cidade", funcionario.Cidade);
                    insert.Parameters.AddWithValue("@Bairro", funcionario.Bairro);
                    insert.Parameters.AddWithValue("@Rua", funcionario.Rua);
                    insert.Parameters.AddWithValue("@Cep", funcionario.Cep);
                    insert.Parameters.AddWithValue("@Numero", funcionario.Numero);
                    insert.Parameters.AddWithValue("@Complemento", funcionario.Complemento);
                    insert.Parameters.AddWithValue("@ContatoEmergencia", funcionario.Contatoemergencia);
                    insert.Parameters.AddWithValue("@Celular", funcionario.Celular);
                    insert.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                    insert.Parameters.AddWithValue("@Email", funcionario.Email);
                    insert.Parameters.AddWithValue("@Salario", funcionario.Salario);

                    try
                    {
                        connection.Open();
                        insert.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Registre o erro para depuração
                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    }
                }
            }
        }


        // chama os dados do banco de dados para verificar se há algum usuário existente //


        public (string username, string senha) Selectfuncionariologin(Funcionario funcionario)
        {
            string username = null;
            string senha = null;
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionstr);
                string query = "SELECT Username, Senha FROM funcionariologin WHERE Username = ? AND Senha = ?";
                var select = new MySqlCommand(query, connection);

                select.Parameters.AddWithValue("1", funcionario.Username);
                select.Parameters.AddWithValue("2", funcionario.Senha);

                connection.Open();
                MySqlDataReader reader = select.ExecuteReader();

                if(reader.Read())
                {
                    username = reader["Username"].ToString();
                    senha = reader["Senha"].ToString();
                }
                connection.Close();


                return (username, senha);
            }
            catch(Exception ex)
            {
                Console.WriteLine("1");
            }

            return (username, senha);
        }

    
    }
}
