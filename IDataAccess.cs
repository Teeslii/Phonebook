using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.models;

namespace Phonebook
{
    public interface IDataAccess
    {
        void RegisterDatabase(PersonDTO directoryDTO);
        int SearchPerson(PersonDTO directoryDTO);
        void DeletePerson(PersonDTO directoryDTO);
        void Update(PersonDTO directoryDTO);
        PersonDTO SearchForUpdatePerson(string _nameSurname);
        PersonDTO MapperSearchForUpdatePerson(Person person);
    }
}
