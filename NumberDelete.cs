using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phonebook.models;
using AutoMapper;

namespace Phonebook
{
    public partial class NumberDelete : Form
    {
        IDataAcces dataAcces;
        public NumberDelete(IDataAcces dataAcces)
        {
            InitializeComponent();
            this.dataAcces = dataAcces;
        }
        Person SearchDto = new Person();
        PersonDTO directoryDTO;

        private void MapperSearch()
        {
            SearchDto.NameSurname = txtNameSurname.Text;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonDTO>());
            var mapper = new Mapper(config);
            directoryDTO = mapper.Map<PersonDTO>(SearchDto);
            ResultForm(dataAcces.SearchPerson(directoryDTO));  
        }
        
        private void ResultForm(int _resultSearch)
        {
            if(_resultSearch == 0)
            {
                MessageBox.Show("The data suitable for the " + txtNameSurname.Text + ". you are looking for could not be found in the directory. Please make a selection. End the deletion or try again!");
   
            }
            else
            {
                pnlDelete.Visible = true;
                lblNameSurname.Text = SearchDto.NameSurname;
                directoryDTO.PersonId = _resultSearch;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            MapperSearch();
            
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            dataAcces.DeletePerson(directoryDTO);
            MessageBox.Show("Process completed.");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No action was taken.");
        }

        
    }
}
