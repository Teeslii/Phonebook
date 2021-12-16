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
    public partial class NumberUpdate : Form
    {
        private readonly IDataAccess _dataAccess;
        public NumberUpdate(IDataAccess _dataAccess)
        {
            InitializeComponent();
            this._dataAccess = _dataAccess;
        }


        Person person = new Person();
        PersonDTO personDTO = new PersonDTO();
         private void MapperFilledField()
         {
                person.PersonId = personDTO.PersonId;
                person.NameSurname = pnlNameSurname.Text;
                person.Number = pnlNumber.Text;
                
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonDTO>());
                var mapper = new Mapper(config);
                personDTO = mapper.Map<PersonDTO>(person);
                _dataAccess.UpdatePerson(personDTO);
         }   

        private void ResultForm()
        {
            personDTO = _dataAccess.SearchForUpdatePerson(txtNameSurname.Text); 

            if (personDTO.PersonId == 0)
            {
                pnlUpdate.Visible = false;
            }
            else
            {
                pnlUpdate.Visible = true;
                pnlNameSurname.Text = personDTO.NameSurname;
                pnlNumber.Text = personDTO.Number;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResultForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MapperFilledField();
            MessageBox.Show("Process completed.");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No action was taken.");
        }

         
    }
}
