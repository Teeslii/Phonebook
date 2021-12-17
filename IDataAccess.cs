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
        void RegisterDatabase(PersonDTO personDTO);
        int SearchPerson(PersonDTO personDTO);
        void DeletePerson(PersonDTO personDTO);
        void UpdatePerson(PersonDTO personDTO);
        PersonDTO SearchForUpdatePerson(string _nameSurname);
        PersonDTO MapperSearchForUpdatePerson(Person person);
        List<PersonDTO> ListingPhonebook();
        List<PersonDTO> MapperListingPhonebook(List<Person> person);
    }
}
