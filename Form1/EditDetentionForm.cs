/************
 * author: Zach Brown
 * date: 2/23/2018
 * assignment: Phase 5 : Project 1
 * professor: Eric Baker
 * course: IGME 201
 * filename: EditDetentionForm.cs
 * description: A program which has the ability to save, load, and clear data. This is programmed specifically for reading the 
 * students and detention programs, however, this program can read any type of JSON file. The data from the students and detention C# files are
 * places into a table on form1.
 ***********/
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class EditDetentionForm : Form
    {
        private Detention d;

        //getter and setter for detention value/attribute
        public Detention Detention
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }

        //constructor
        public EditDetentionForm()
        {
            InitializeComponent();
        }

        //load detention record with information 
        public void LoadDetentionRecord(Detention d)
        {
            this.Detention = d;
            reason.Text = d.Reason;
            punishment.Text = d.Punishment;
            issuedby.Text = d.IssuedBy;
            pointstaken.Value = d.PointsTaken;
            dateissued.Value = d.Date;
            dateissued.Enabled = false;
            issuedby.ReadOnly = true;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //save method if clicked, saves each category individually
        private void SaveButton_Click(object sender, EventArgs e)
        {
            d.Reason = reason.Text;
            d.Punishment = punishment.Text;
            d.IssuedBy = issuedby.Text;
            d.PointsTaken = (int)pointstaken.Value;
            d.Date = dateissued.Value;

            this.Close();
        }

        //close method closes the window
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
