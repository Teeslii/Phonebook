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
using AutoMapper;


namespace Phonebook
{
    public class DataAccess : IDataAccess
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Phonebook.Properties.Settings.Setting"].ConnectionString;
 
       
        public int SearchPerson(PersonDTO personDTO)
        {
           using(var connectionSearch = new SqlConnection(connectionString))
            {
               
                connectionSearch.Open();
                string Search = "select PersonId from Person where  NameSurname Like '%'+ @NameSurname +'%'";
                SqlCommand SearchCommand = new SqlCommand(Search, connectionSearch);
              
                SearchCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NVarChar, 250) { Value = personDTO.NameSurname });


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
        public void DeletePerson(PersonDTO personDTO)
        {
            using(var connectionDelete = new SqlConnection(connectionString))
            {
                connectionDelete.Open();
                string Delete = "Delete from Person where  PersonId = @PersonId";
                SqlCommand DeleteCommand = new SqlCommand(Delete, connectionDelete);
                DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PersonId", SqlDbType.Int) { Value = personDTO.PersonId});
                
                DeleteCommand.ExecuteNonQuery();
                connectionDelete.Close();
            }
        }
        public void RegisterDatabase(PersonDTO personDTO)
        {
            using (var connectionRegister = new SqlConnection(connectionString))
            {
                connectionRegister.Open();

                string registerPerson = "Insert into Person(NameSurname, Number) values(@NameSurname,  @Number)";
                SqlCommand sqlCommand = new SqlCommand(registerPerson, connectionRegister);

                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NChar, 15) { Value = personDTO.NameSurname });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Number", SqlDbType.VarChar, 11) { Value = personDTO.Number });
                sqlCommand.ExecuteNonQuery();
                connectionRegister.Close();
            }
        }

        public  PersonDTO MapperSearchForUpdatePerson(Person person)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonDTO>());
            var mapper = new Mapper(config);
            var personDTO = mapper.Map<PersonDTO>(person);
            return personDTO;
        }

        public PersonDTO SearchForUpdatePerson(string _nameSurname)
        {
            using (var connectionSearch = new SqlConnection(connectionString))
            {
                connectionSearch.Open();

                Person person = new Person();
                string SearchQuery = "SELECT TOP 1 PersonId, NameSurname, Number FROM Person WHERE  NameSurname LIKE '%'+ @NameSurname +'%'";
                var cmd = new SqlCommand(SearchQuery, connectionSearch);
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NVarChar, 250) { Value = _nameSurname });
                 
                var reader = cmd.ExecuteReader();
                
                if(!reader.HasRows)
                {
                    System.Windows.Forms.MessageBox.Show("No record found named " + _nameSurname + ". Please try again");
                }
                else
                {
                    
                    while(reader.Read())
                    {
                        if (!int.TryParse(reader["PersonId"].ToString().ToString(), out int _PersonId))
                        {
                            System.Windows.Forms.MessageBox.Show("An error occurred while retrieving the registered customer's ID.");
                        }
                        person.PersonId = _PersonId;
                        person.NameSurname = reader["NameSurname"].ToString();
                        person.Number = reader["Number"].ToString();
                       
                    }

                }
                
          
                reader.Close();
                connectionSearch.Close();
                return MapperSearchForUpdatePerson(person);
            }
        }

        public void UpdatePerson(PersonDTO personDTO)
        {
            using(var ConnectionUpdate = new SqlConnection(connectionString))
            {
                ConnectionUpdate.Open();

                string UpdateQuery = "Update Person SET NameSurname = @NameSurname , Number = @Number where PersonId = @PersonId ";
                var cmd = new SqlCommand(UpdateQuery, ConnectionUpdate);
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PersonId", SqlDbType.Int) { Value = personDTO.PersonId });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NameSurname", SqlDbType.NChar, 15) { Value = personDTO.NameSurname });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Number", SqlDbType.VarChar, 11) { Value = personDTO.Number });
                cmd.ExecuteNonQuery();

                ConnectionUpdate.Close();
            }
        }
        public List<PersonDTO> MapperListingPhonebook(List<Person> person)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonDTO>());
            var mapper = new Mapper(config);
            List<PersonDTO> personDto = mapper.Map<List<Person>, List<PersonDTO>>(person);
            return personDto;

        }
        public List<PersonDTO> ListingPhonebook()
        {
            using(var connectionList= new SqlConnection(connectionString))
            {
                connectionList.Open();
                string ListingPhonebookQuery = "SELECT PersonId, NameSurname, Number FROM Person";
                List<Person> personList = new List<Person>();
                var cmd = new SqlCommand(ListingPhonebookQuery, connectionList);

                var reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    if (!int.TryParse(reader["PersonId"].ToString().ToString(), out int _PersonId))
                    {
                        System.Windows.Forms.MessageBox.Show("An error occurred while retrieving the registered customer's ID.");
                    }
                    personList.Add(new Person { PersonId = _PersonId, NameSurname = reader["NameSurname"].ToString(), Number = reader["Number"].ToString() });
                }
                return MapperListingPhonebook(personList);
                reader.Close();
                connectionList.Close();
            }
        }
    }
}
