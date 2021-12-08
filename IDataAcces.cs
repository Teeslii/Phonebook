using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.models;

namespace Phonebook
{
    public interface IDataAcces
    {
        void RegisterDatabase(PersonDTO directoryDTO);
        bool SearchPerson(PersonDTO directoryDTO);
        void Delete(PersonDTO directoryDTO);
        void Update(PersonDTO directoryDTO);
        
        
    }
}
