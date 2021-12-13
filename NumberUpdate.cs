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


        Person SearchDto = new Person();
        PersonDTO directoryDTO;
        private void MapperDto()
        {
            SearchDto.NameSurname = txtNameSurname.Text;
             
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonDTO>());
            var mapper = new Mapper(config);
            directoryDTO = mapper.Map<PersonDTO>(SearchDto);
            ResultForm(_dataAccess.SearchPerson(directoryDTO));
        }

        private void ResultForm(int _resultSearch)
        {
            if (_resultSearch == 0)
            {
                MessageBox.Show("No record found named " + txtNameSurname.Text + ". Please try again");
                pnlUpdate.Visible = true;
                pnlNameSurname.Text = directoryDTO.NameSurname;
                pnlNumber.Text = directoryDTO.Number.ToString();
            }
            else
            {
                pnlUpdate.Visible = true;
                pnlNameSurname.Text = directoryDTO.NameSurname;
                pnlNumber.Text = directoryDTO.Number.ToString();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            MapperDto();
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
