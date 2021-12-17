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
    public partial class ListingPhonebook : Form
    {
        private readonly IDataAccess _dataAccess;
        public ListingPhonebook(IDataAccess _dataAccess)
        {
            InitializeComponent();
            this._dataAccess = _dataAccess;
        }
        
        private void ShowListingPhonebook()
        {
            List<PersonDTO> personDTO = _dataAccess.ListingPhonebook();

            foreach(PersonDTO getPhonebook in personDTO)
            {
                ListViewItem personList = new ListViewItem();
                personList.Text = getPhonebook.PersonId.ToString();
                personList.SubItems.Add(getPhonebook.NameSurname);
                personList.SubItems.Add(getPhonebook.Number);

                listViewPhonebook.Items.Add(personList);
            }


        }
        private void ListingPhonebook_Load(object sender, EventArgs e)
        {
            ShowListingPhonebook();
        }
    }
}
