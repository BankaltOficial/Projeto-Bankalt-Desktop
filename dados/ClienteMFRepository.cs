using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace dados
{
    public class ClienteMFRepository
    {
        private string connectionstr = "Server=143.106.241.4;Database=cl203231;User ID=cl203231;Password=cl*25122007;";
        public ClienteMF VoltaDadosPessoaisClienteMaiorDeIdade(string cpf)
        {
            ClienteMF cliente = new ClienteMF();
            try
            {
                string query = "SELECT * FROM clienteDadosPessoaFisica WHERE Cpf = @Cpf";

                using (MySqlConnection connection = new MySqlConnection(connectionstr))
                using (MySqlCommand select = new MySqlCommand(query, connection))
                {
                    // Adiciona o parâmetro @Cpf
                    select.Parameters.AddWithValue("@Cpf", cpf);

                    connection.Open();
                    using (MySqlDataReader reader = select.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente.Nome = reader["Nome"].ToString();
                            cliente.Sexo1 = reader["Sexo"].ToString();
                            cliente.Datanascimento = DateTime.Parse(reader["DataNascimento"].ToString());
                            cliente.Rg = reader["Rg"].ToString();
                            cliente.Cpf = reader["Cpf"].ToString();
                            cliente.Estadocivil = reader["EstadoCivil"].ToString();
                            cliente.Pais = reader["Pais"].ToString();
                            cliente.Estado = reader["Estado"].ToString();
                            cliente.Cidade = reader["Cidade"].ToString();
                            cliente.Bairro = reader["Bairro"].ToString();
                            cliente.Rua = reader["Rua"].ToString();
                            cliente.Numero = reader["Numero"].ToString();
                            cliente.Cep = reader["Cep"].ToString();
                            cliente.Complemento = reader["Complemento"].ToString();
                            cliente.Telefone = reader["Telefone"].ToString();
                            cliente.Celular = reader["Celular"].ToString();
                            cliente.Email = reader["Email"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            return cliente;
        }

        public void AtualizarCliente(ClienteMF cliente)
        {
            try
            {
                string query = @"UPDATE clienteDadosPessoaFisica 
                         SET Nome = @Nome, 
                             Sexo = @Sexo, 
                             DataNascimento = @DataNascimento, 
                             Rg = @Rg, 
                             EstadoCivil = @EstadoCivil, 
                             Pais = @Pais, 
                             Estado = @Estado, 
                             Cidade = @Cidade, 
                             Bairro = @Bairro, 
                             Rua = @Rua, 
                             Numero = @Numero, 
                             Cep = @Cep, 
                             Complemento = @Complemento, 
                             Telefone = @Telefone, 
                             Celular = @Celular, 
                             Email = @Email
                         WHERE Cpf = @Cpf";

                using (MySqlConnection connection = new MySqlConnection(connectionstr))
                using (MySqlCommand updateCommand = new MySqlCommand(query, connection))
                {
                    // Adiciona os parâmetros com os valores do objeto `cliente`
                    updateCommand.Parameters.AddWithValue("@Nome", cliente.Nome);
                    updateCommand.Parameters.AddWithValue("@Sexo", cliente.Sexo1);
                    updateCommand.Parameters.AddWithValue("@DataNascimento", cliente.Datanascimento);
                    updateCommand.Parameters.AddWithValue("@Rg", cliente.Rg);
                    updateCommand.Parameters.AddWithValue("@EstadoCivil", cliente.Estadocivil);
                    updateCommand.Parameters.AddWithValue("@Pais", cliente.Pais);
                    updateCommand.Parameters.AddWithValue("@Estado", cliente.Estado);
                    updateCommand.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                    updateCommand.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                    updateCommand.Parameters.AddWithValue("@Rua", cliente.Rua);
                    updateCommand.Parameters.AddWithValue("@Numero", cliente.Numero);
                    updateCommand.Parameters.AddWithValue("@Cep", cliente.Cep);
                    updateCommand.Parameters.AddWithValue("@Complemento", cliente.Complemento);
                    updateCommand.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                    updateCommand.Parameters.AddWithValue("@Celular", cliente.Celular);
                    updateCommand.Parameters.AddWithValue("@Email", cliente.Email);
                    updateCommand.Parameters.AddWithValue("@Cpf", cliente.Cpf); // CPF para identificar o registro a ser atualizado

                    // Abre a conexão e executa o comando
                    connection.Open();
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    // Opcional: exibe o resultado da atualização
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Cliente atualizado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum cliente encontrado com o CPF especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar cliente: " + ex.Message);
            }
        }

    }
}