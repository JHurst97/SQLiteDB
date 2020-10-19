using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteDemo
{
    public partial class Form1 : Form
    {

        List<PersonModel> people = new List<PersonModel>();

        public Form1()
        {
            InitializeComponent();

            LoadPeople();
        }

        public void LoadPeople()
        {
            people = SQLiteDataAccess.LoadPeople();
            WireUpList();
        }

        public void WireUpList()
        {
            listBox.DataSource = null;
            listBox.DataSource = people;
            listBox.DisplayMember = "FullName";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SQLiteDataAccess.AddPeople(new PersonModel { FirstName = firstNameTb.Text, LastName = lastNameTb.Text });
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadPeople();
        }
    }
}
