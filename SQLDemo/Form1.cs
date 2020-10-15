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

namespace SQLDemo
{
    public partial class Form1 : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        public Form1()
        {
            InitializeComponent();

            LoadPeopleList(); 
        }

        private void LoadPeopleList()
        {
            people = SQLiteDataAccess.LoadPeople();

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            ListPeopleLB.DataSource = null;
            ListPeopleLB.DataSource = people;
            ListPeopleLB.DisplayMember = "FullName";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
            p.FirstName = FirstNameTB.Text;
            p.LastName = LastNameTB.Text;

            SQLiteDataAccess.SavePerson(p);

            FirstNameTB.Text = "";
            LastNameTB.Text = "";
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }
    }
}
