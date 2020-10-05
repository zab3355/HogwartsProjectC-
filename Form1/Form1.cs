/************
 * author: Zach Brown
 * date: 2/23/2018
 * assignment: Phase 5 : Project 1
 * professor: Eric Baker
 * course: IGME 201
 * filename: Form1.cs
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
    public partial class Form1 : Form
    {
        //defining the filemanager named fileMan and list of students as an array named students.
        FileManager fileMan = new FileManager();
        List<Student> students = new List<Student>();
        private Student selectedStudent = new Student();
        private int selectedStudentIndex = -1;

        public object ListBox1 { get; private set; }

        //constructor, initializes the components necessary
        public Form1()
        {
            InitializeComponent();
        }

        //activates the save button, opens the save file dialog
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.ShowDialog();

        }

        //activates the load button, opens the open file dialog 
        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.ShowDialog();
        }

        //activates the clear button, clears all student and listview data.
        private void ClearButton_Click(object sender, EventArgs e)
        {
            students.Clear();
            studentNameTextBox.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            Yes.Checked = false;
            No.Checked = false;
            detentionBox1.Items.Clear();
            yearComboBox.SelectedIndex = -1;
            classBox1.Items.Clear();
            studentComboBox.SelectedIndex = -1;
            studentComboBox.Items.Clear();
        }


        //open file dialog, opens the open file window and specific loads information that would be located in the Students and 
        //Detention programs. Puts into a listview table.
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            bool tmp = fileMan.LoadJsonFile(OpenFileDialog1.FileName, out students);

            //Puts students into Datasource and DisplayMember uses reflection to show students in combobox
            foreach(Student s in students)
            {
                studentComboBox.Items.Add(s);
            }
            studentComboBox.DisplayMember = "Name";
    
            //if the load fails, messagebox shows that the load has failed
            if (!tmp)
            {
                MessageBox.Show("Error.", "Load Failed.");
            }
        }

        //save file dialog, opens the save file window
        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            selectedStudent.Name = studentNameTextBox.Text;
            selectedStudent.DateOfBirth = dateTimePicker1.Value;
            selectedStudent.DateOfGraduation = dateTimePicker2.Value;
            selectedStudent.Detentions.Clear();
            foreach(Detention d in detentionBox1.Items)
            {
                selectedStudent.Detentions.Add(d);
            }
            selectedStudent.HasHogsmeadePermissioniForm = Yes.Checked;
            selectedStudent.House = (HogwartsHouse)comboBox1.SelectedIndex;
            selectedStudent.YearLevel = yearComboBox.SelectedIndex;

            students.RemoveAt(selectedStudentIndex);
            students.Insert(selectedStudentIndex, selectedStudent);

            bool tmp = fileMan.SaveJsonFile(SaveFileDialog1.FileName, students);

            //if the save fails, messagebox shows that the save function has failed.
            if (!tmp)
            {
                MessageBox.Show("Error.", "Save Failed.");
            }
        }


        //students combo box
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentComboBox.SelectedIndex > -1 && studentComboBox.SelectedItem != null)
            {
                detentionBox1.Items.Clear();
                classBox1.Items.Clear();
                yearComboBox.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;

                var student = (Student)studentComboBox.SelectedItem;
                selectedStudent = student;
                selectedStudentIndex = studentComboBox.SelectedIndex;
                studentNameTextBox.Text = student.Name;
                if (student.HasHogsmeadePermissioniForm)
                {
                    Yes.Checked = true;
                }
                else
                {
                    No.Checked = true;
                }
                dateTimePicker1.Value = student.DateOfBirth;
                //if the date does not meet the calendar guidelines or else set date to today
                if(student.DateOfGraduation <= dateTimePicker1.MinDate || student.DateOfGraduation >= dateTimePicker1.MaxDate)
                {
                    dateTimePicker2.Value = DateTime.Today;
                }
                else
                {
                    dateTimePicker2.Value = student.DateOfGraduation;
                }
                comboBox1.SelectedIndex = (int)student.House;
                comboBox2.SelectedIndex = student.YearLevel;

                //populating detentions
                foreach(Detention d in student.Detentions)
                {
                    detentionBox1.Items.Add(d);
                }
                detentionBox1.DisplayMember = "Punishment";

            }
        }
        /*
         *Methods for Detention tasks 
        */
        //adding to detention form
        private void Add_Click(object sender, EventArgs e)
        {
            var editDetentionForm = new EditDetentionForm();
            editDetentionForm.FormClosing += NewDetentionFormClosing;
            editDetentionForm.ShowDialog(this);
        }

        //method which physically adds the data to the form
        private void NewDetentionFormClosing(object detentionForm, EventArgs e)
        {
            Detention detentionRecord = (detentionForm as EditDetentionForm).Detention;

            detentionBox1.Items.Add(detentionRecord);
        }

        //deleting from detention form
        private void Delete_Click(object sender, EventArgs e)
        {
            if (detentionBox1.SelectedIndex > -1)
            {
                var d = (Detention)detentionBox1.SelectedItem;
                detentionBox1.Items.RemoveAt(detentionBox1.SelectedIndex);
            }
        }

        //editing objects in the detention form
        private void Edit_Click(object sender, EventArgs e)
        {
            var editDetentionForm = new EditDetentionForm();
            if(detentionBox1.SelectedIndex > -1)
            {
                var d = (Detention)detentionBox1.SelectedItem;
                editDetentionForm.LoadDetentionRecord(d);
                editDetentionForm.FormClosing += DetentionFormClosing;
                editDetentionForm.ShowDialog(this);
            }
           
        }

        //closing the detention form
        private void DetentionFormClosing(object detentionForm, EventArgs e)
        {
            Detention detentionRecord = (detentionForm as EditDetentionForm).Detention;

            detentionBox1.Items[detentionBox1.SelectedIndex] = detentionRecord;
        }

        /*
         *Class list tasks 
        */ 

        //adding data to the class list
        private void Add2_Click(object sender, EventArgs e)
        {
            var editSubjectForm = new EditClassForm();
            editSubjectForm.FormClosing += NewSubjectFormClosing;
            editSubjectForm.ShowDialog(this);
        }

        //adding and categorizing the subject by year
        private void NewSubjectFormClosing(object subjectForm, EventArgs e)
        {
            SubjectGrade subjectGradeRecord = (subjectForm as EditClassForm).ClassGrade;
            int year = (subjectForm as EditClassForm).Year;

                //for loop to count subjects by the year and organize
                for (int i = selectedStudent.Subjects.Count - 1; i < year; i++)
                {
                    selectedStudent.Subjects.Add(new List<SubjectGrade>());
                }
            if (year != yearComboBox.SelectedIndex)
            {
                classBox1.Items.Add(subjectGradeRecord);
            }

            selectedStudent.Subjects[year].Add(subjectGradeRecord);
        }

        //delete method for class list
        private void Delete2_Click(object sender, EventArgs e)
        {
            if (classBox1.SelectedIndex > -1)
            {
                var d = (SubjectGrade)classBox1.SelectedItem;
                selectedStudent.Subjects[yearComboBox.SelectedIndex].RemoveAt(classBox1.SelectedIndex);
                classBox1.Items.RemoveAt(classBox1.SelectedIndex);

            }
        }

        //edit method to edit from the class list
        private void Edit2_Click(object sender, EventArgs e)
        {
            var editSubjectForm = new EditClassForm();
            if(classBox1.SelectedIndex > -1)
            {
                var subjectGrade = (SubjectGrade)classBox1.SelectedItem;
                editSubjectForm.LoadClassGrade(subjectGrade, yearComboBox.SelectedIndex);
                editSubjectForm.FormClosing += EditSubjectFormClosing;
                editSubjectForm.ShowDialog(this);
            }
        }

        //edit form closing method to actually edit from each year
        private void EditSubjectFormClosing(object subjectForm, EventArgs e)
        {
            //grabs subject grade from subject form, pull out year
            SubjectGrade subjectGradeRecord = (subjectForm as EditClassForm).ClassGrade;
            int year = (subjectForm as EditClassForm).Year;
            
            //if year is changed: move courses from the year combobox, indexed subjects by year
            if(year != yearComboBox.SelectedIndex)
            {
                selectedStudent.Subjects[yearComboBox.SelectedIndex].RemoveAt(classBox1.SelectedIndex);

                //for loop for adding selected students in subject grade, add new collections
                for(int i = selectedStudent.Subjects.Count - 1; i < year; i++)
                {
                    selectedStudent.Subjects.Add(new List<SubjectGrade>());
                }
                //adds to correct year and remove subject editing from the listbox
                selectedStudent.Subjects[year].Add(subjectGradeRecord);
                classBox1.Items.RemoveAt(classBox1.SelectedIndex);
            }

            else
            {
                //if year wasnt changed: just look at subjects collection and index to it, then overwrites it.
                selectedStudent.Subjects[yearComboBox.SelectedIndex][classBox1.SelectedIndex] = subjectGradeRecord;
                classBox1.Items[classBox1.SelectedIndex] = subjectGradeRecord;
            }
        }

        //year combobox for displaying by year 
        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(yearComboBox.SelectedIndex > -1)
            {
                classBox1.Items.Clear();
                if((selectedStudent.Subjects.Count-1) >= yearComboBox.SelectedIndex)
                {
                    foreach(SubjectGrade subject in selectedStudent.Subjects[yearComboBox.SelectedIndex])
                    {
                        classBox1.Items.Add(subject);
                        classBox1.DisplayMember = "Subject";
                    }
                }
            }
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
