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
// "Insert into Room(ID, roomNo, checkIn, IsDelete) values ( @ID, @roomNo, GETDATE(), 'False')";
//   string queryIsDelete = "select roomNo from Room where IsDelete= 'False'";

//   string deleteQuery = "update Room set IsDelete='True', checkOut=GETDATE() where roomNo = @_roomNo";

namespace Phonebook
{
    public class DataAcces : IDataAcces
    {
        private string connectionString = "Data Source=LAPTOP-VBIOM4D2;Initial Catalog = Phonebook; Integrated Security = True";

        private bool _resultSeach;
       
        public bool Search(PersonDTO directoryDTO)
        {
           using(var connectionSearch = new SqlConnection(connectionString))
            {
               
                connectionSearch.Open();
                string Search = "select Name, Lastname, Number from Person where Name = @name and Lastname = @lastname";
                SqlCommand SearchCommand = new SqlCommand(Search,connectionSearch);
                SearchCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", SqlDbType.NChar, 15) { Value = directoryDTO.Name });
                SearchCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lastname", SqlDbType.NChar, 15) { Value = directoryDTO.Lastname });


                SqlDataReader sqlDataReader = SearchCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    directoryDTO.Name = sqlDataReader["Name"].ToString();
                    directoryDTO.Lastname = sqlDataReader["Lastname"].ToString();
                    long.TryParse(sqlDataReader["Number"].ToString(), out long Number);
                    directoryDTO.Number = Number;

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
                string Delete = "Delete from Person where  Name = @name and Lastname = @lastname";
                SqlCommand DeleteCommand = new SqlCommand(Delete, connectionDelete);
                DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", SqlDbType.NChar, 15) { Value = directoryDTO.Name });
                DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lastname", SqlDbType.NChar, 15) { Value = directoryDTO.Lastname });
                DeleteCommand.ExecuteNonQuery();
                connectionDelete.Close();
            }
        }
        public void RegisterDatabase(PersonDTO directoryDTO)
        {
            using (var connectionRegister = new SqlConnection(connectionString))
            {
                connectionRegister.Open();

                string registerPerson = "Insert into Person(Name, Lastname, Number) values(@name, @lastname, @number)";
                SqlCommand sqlCommand = new SqlCommand(registerPerson, connectionRegister);
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", SqlDbType.NChar, 15) { Value = directoryDTO.Name });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lastname", SqlDbType.NChar, 15) { Value = directoryDTO.Lastname });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@number", SqlDbType.VarChar, 11) { Value = directoryDTO.Number });
                sqlCommand.ExecuteNonQuery();
                connectionRegister.Close();
            }
        }

        public void Update(PersonDTO directoryDTO)
        {
            using(var ConnectionUpdate = new SqlConnection(connectionString))
            {
                ConnectionUpdate.Open();
                string Update = "Update Person SET Name = , Lastname =  where  Name = @name and Lastname = @lastname  ";
                ConnectionUpdate.Close();
            }
        }
    }
}
