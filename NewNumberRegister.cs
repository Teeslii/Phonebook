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
       
        public IDataAcces dataAcces;
        public NewNumberRegister(IDataAcces dataAcces)
        {
            InitializeComponent();
            this.dataAcces = dataAcces;
        }


        Person directory = new Person();
        public void MapperDirectory()
        { 
             
            directory.NameSurname = txtNameSurname.Text;
            directory.Number = txtNumber.Text;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonDTO>());
            var mapper= new Mapper(config);
            var directoryDTO = mapper.Map<PersonDTO>(directory);
            dataAcces.RegisterDatabase(directoryDTO);
            MessageBox.Show("işlem başarıyla tamamlandı.");


        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            MapperDirectory();
            
        }

       
    }
}
