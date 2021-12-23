using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using Phonebook.models;

namespace Phonebook
{
    public partial class NewNumberRegister : Form
    {

        private readonly IDataAccess _dataAccess;
        public NewNumberRegister(IDataAccess _dataAccess)
        {
            InitializeComponent();
            this._dataAccess = _dataAccess;
        }


        Person directory = new Person();
        public void MapperDirectory()
        { 
             
            directory.NameSurname = txtNameSurname.Text;
            directory.Number = txtNumber.Text;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonDTO>());
            var mapper= new Mapper(config);
            var directoryDTO = mapper.Map<PersonDTO>(directory);
            _dataAccess.RegisterDatabase(directoryDTO);
            MessageBox.Show("The operation completed successfully.");


        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            MapperDirectory();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
            this.Hide();

        }
    }
}
