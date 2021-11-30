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
        private readonly string connectionString = "Data Source=LAPTOP-VBIOM4D2;Initial Catalog = Phonebook; Integrated Security = True";

        private bool _resultSeach;
       
        public bool Search(PersonDTO directoryDTO)
        {
           using(var connectionSearch = new SqlConnection(connectionString))
            {
               
                connectionSearch.Open();
                string Search = "select NameSurname from Person where  NameSurname Like '%'+ @NameSurname +'%'";
                SqlCommand SearchCommand = new SqlCommand(Search,connectionSearch);
              
                SearchCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NChar, 15) { Value = directoryDTO.NameSurname });

                SqlDataReader sqlDataReader = SearchCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
              
                    directoryDTO.NameSurname = sqlDataReader["NameSurname"].ToString();
                    directoryDTO.Number = sqlDataReader["Number"].ToString();

                    _resultSeach = true;
                }

                sqlDataReader.Close();
                connectionSearch.Close();
            }
            return _resultSeach;
        }
        public void Delete(PersonDTO directoryDTO)
        {
            using(var connectionDelete = new SqlConnection(connectionString))
            {
                connectionDelete.Open();
                string Delete = "Delete from Person where  NameSurname = @NameSurname";
                SqlCommand DeleteCommand = new SqlCommand(Delete, connectionDelete);
                DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NChar, 15) { Value = directoryDTO.NameSurname });
                
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
