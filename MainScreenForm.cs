using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class MainScreenForm : Form
    {
        private readonly IDataAccess _dataAccess;

        public MainScreenForm()
        {
            InitializeComponent();
            _dataAccess = (IDataAccess)Program.ServiceProvider.GetService(typeof(IDataAccess));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            NewNumberRegister newNumberRegister = new NewNumberRegister(_dataAccess);
            newNumberRegister.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NumberDelete numberDelete = new NumberDelete(_dataAccess);
            numberDelete.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NumberUpdate numberUpdate = new NumberUpdate(_dataAccess);
            numberUpdate.Show();
            this.Hide();
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            ListingPhonebook listingPhonebook = new ListingPhonebook(_dataAccess);
            listingPhonebook.Show();
            this.Hide();
        }
    }
}
