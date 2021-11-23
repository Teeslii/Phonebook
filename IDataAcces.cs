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
        void RegisterDatabase(DirectoryDTO directoryDTO);
        bool Search(DirectoryDTO directoryDTO);
        void Delete(DirectoryDTO directoryDTO);
        void Update(DirectoryDTO directoryDTO);
        
        
    }
}
