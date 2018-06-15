using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataDirectoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            dataDirectoryBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(phoneBookDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataDirectoryTableAdapter.Fill(phoneBookDataSet.DataDirectory);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataDirectoryBindingSource.Filter = "FirstName Like '" + txtSearch.Text + "%' OR Lastname Like '" + txtSearch.Text + "%' OR [Telephone Number] Like '" + txtSearch.Text + "%'";
        }
    }
}
