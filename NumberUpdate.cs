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
        //private void MapperDto()
        //{
        //    SearchDto.NameSurname = txtNameSurname.Text;
             
        //    var config = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonDTO>());
        //    var mapper = new Mapper(config);
        //    directoryDTO = mapper.Map<PersonDTO>(SearchDto);
        //     
        //}

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

            MessageBox.Show("Process completed.");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No action was taken.");
        }

         
    }
}
