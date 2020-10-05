/************
 * author: Zach Brown
 * date: 2/23/2018
 * assignment: Phase 5 : Project 1
 * professor: Eric Baker
 * course: IGME 201
 * filename: EditClassForm.cs
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
    public partial class EditClassForm : Form
    {
        private SubjectGrade classGrade;

        //getter and setter for classgrade
        public SubjectGrade ClassGrade
        {
            get
            {
                return classGrade;
            }
            set
            {
                classGrade = value;
            }
        }
        private int year;

        //getter and setter for year
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        //constructor
        public EditClassForm()
        {
            InitializeComponent();
        }

        public void LoadClassGrade(SubjectGrade classGrade, int year)
        {
            this.classGrade = classGrade;
            YearBox.SelectedIndex = year;
            SubjectBox.SelectedIndex = (int)this.classGrade.Subject;
            GradeBox.SelectedIndex = (int)this.classGrade.Grade;
        }

        //Method when clicked, saves grade, subject and year to database
        private void Save_Click(object sender, EventArgs e)
        {
            this.classGrade.Grade = (GradeScale)GradeBox.SelectedIndex;
            this.classGrade.Subject = (HogwartsSubject)SubjectBox.SelectedIndex;
            this.year = YearBox.SelectedIndex;

            this.Close();
        }

        //Method when clicked, closes the window
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
