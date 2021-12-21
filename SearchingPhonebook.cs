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

namespace Phonebook
{
    public partial class SearchingPhonebook : Form
    {
        private readonly IDataAccess _dataAccess;
        public SearchingPhonebook(IDataAccess _dataAccess)
        {
            InitializeComponent();
            this._dataAccess = _dataAccess;
        }

        PersonDTO personDTO = new PersonDTO();

        private void ResultSearch()
        {
            if(personDTO.PersonId == 0)
            {
               pnlResultFound.Visible = false;

            }
            else
            {
                lblPersonId.Text = personDTO.PersonId.ToString();
                lblNameSurname.Text = personDTO.NameSurname;
                lblNumber.Text = personDTO.Number;
            }
        }

        private void btnSearchNameSurname_Click(object sender, EventArgs e)
        { 
            personDTO = _dataAccess.SearchByNameNumber(txtNameSurname.Text, null);
            ResultSearch();
        }

        private void btnSearchNumber_Click(object sender, EventArgs e)
        {
            personDTO = _dataAccess.SearchByNameNumber(null, txtNumber.Text);
            ResultSearch();
        }
    }
}
