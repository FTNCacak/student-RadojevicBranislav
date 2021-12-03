using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly StudentBusiness studentBusiness;

        
        public Form1()
        {
            this.studentBusiness = new StudentBusiness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            List<Student> students = this.studentBusiness.GetAllStudents();

            listBox_Students.Items.Clear();

            foreach(Student s in students)
            {
                listBox_Students.Items.Add(s.Id + "  " + s.Name + ", Prosek: " + s.AverageMark);
            }
        }

        private void button_Kreiraj_Click(object sender, EventArgs e)
        {
            Student s = new Student();

            s.Name = textBox_Name.Text;

            s.IndexNumber = textBox_IndexNum.Text;

            s.AverageMark = Convert.ToDecimal(textBox_AvgMark.Text);

            if (this.studentBusiness.InsertStudent(s))
            {
                RefreshData();
                textBox_Name.Clear();
                textBox_IndexNum.Clear();
                textBox_AvgMark.Clear();
            }
            else
                MessageBox.Show("Greska!");
        }
    }
}
