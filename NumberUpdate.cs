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
        IDataAcces dataAcces;
        public NumberUpdate(IDataAcces dataAcces)
        {
            InitializeComponent();
            this.dataAcces = dataAcces;
        }


        Person SearchDto = new Person();
        PersonDTO directoryDTO;
        private void MapperDto()
        {
            SearchDto.Name = txtName.Text;
            SearchDto.Lastname = txtLastname.Text;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonDTO>());
            var mapper = new Mapper(config);
            directoryDTO = mapper.Map<PersonDTO>(SearchDto);
            ResultForm(dataAcces.Search(directoryDTO));
        }

        private void ResultForm(bool _resultSearch)
        {
            if (_resultSearch == true)
            {
                pnlUpdate.Visible = true;
                pnlName.Text = directoryDTO.Name;
                pnlLastname.Text = directoryDTO.Lastname;
                pnlNumber.Text = directoryDTO.Number.ToString();
            }
            else
            {
                MessageBox.Show("No record found named " + txtName.Text + " " + txtLastname.Text + ". Please try again");
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
