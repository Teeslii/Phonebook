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
        
       
        //public NewNumberRegister(IDataAcces dataAcces)
        //{
        //    this.dataAcces = dataAcces;
        //}
        Directory directory = new Directory();
        public void MapperDirectory()
        { 
            directory.Name = txtName.Text;
            directory.Lastname = txtSurname.Text;
            long.TryParse(txtNumber.Text, out long number);
            directory.Number = number;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Directory, DirectoryDTO>());
            var mapper= new Mapper(config);
            var directoryDTO = mapper.Map<DirectoryDTO>(directory);
            dataAcces.RegisterDatabase(directoryDTO);
            MessageBox.Show("işlem başarıyla tamamlandı.");


        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            MapperDirectory();
            
        }

       
    }
}
