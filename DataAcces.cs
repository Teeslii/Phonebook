using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Phonebook.models;
 

namespace Phonebook
{
    public class DataAcces : IDataAcces
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Phonebook.Properties.Settings.Setting"].ConnectionString;

        private bool _resultSeach;
       
        public int SearchPerson(PersonDTO directoryDTO)
        {
           using(var connectionSearch = new SqlConnection(connectionString))
            {
               
                connectionSearch.Open();
                string Search = "select PersonId from Person where  NameSurname Like '%'+ @NameSurname +'%'";
                SqlCommand SearchCommand = new SqlCommand(Search, connectionSearch);
              
                SearchCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NVarChar, 250) { Value = directoryDTO.NameSurname });


                  var findPersonId = SearchCommand.ExecuteScalar();
                 

                if (findPersonId == null)
                {
                    System.Windows.Forms.MessageBox.Show("An error occurred while retrieving the registered customer's ID.");
                    return 0;
                }
                else
                {
                    if (!int.TryParse(findPersonId.ToString(), out int _PersonId))
                    {
                        System.Windows.Forms.MessageBox.Show("An error occurred while retrieving the registered customer's ID.");
                    }
                    return _PersonId;
                }

                connectionSearch.Close();
            }
             
        }
        public void DeletePerson(PersonDTO directoryDTO)
        {
            using(var connectionDelete = new SqlConnection(connectionString))
            {
                connectionDelete.Open();
                string Delete = "Delete from Person where  PersonId = @PersonId";
                SqlCommand DeleteCommand = new SqlCommand(Delete, connectionDelete);
                DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PersonId", SqlDbType.Int) { Value = directoryDTO.PersonId});
                
                DeleteCommand.ExecuteNonQuery();
                connectionDelete.Close();
            }
    }
        public void RegisterDatabase(PersonDTO directoryDTO)
        {
            using (var connectionRegister = new SqlConnection(connectionString))
            {
                connectionRegister.Open();

                string registerPerson = "Insert into Person(NameSurname, Number) values(@NameSurname,  @Number)";
                SqlCommand sqlCommand = new SqlCommand(registerPerson, connectionRegister);
               
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NChar, 15) { Value = directoryDTO.NameSurname });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Number", SqlDbType.VarChar, 11) { Value = directoryDTO.Number });
                sqlCommand.ExecuteNonQuery();
                connectionRegister.Close();
            }
        }

        public void Update(PersonDTO directoryDTO)
        {
            using(var ConnectionUpdate = new SqlConnection(connectionString))
            {
                ConnectionUpdate.Open();
                string Update = "Update Person SET NameSurname = @NameSurname , Number = @Number where PersonId = @PersonId ";

                ConnectionUpdate.Close();
            }
        }
    }
}
