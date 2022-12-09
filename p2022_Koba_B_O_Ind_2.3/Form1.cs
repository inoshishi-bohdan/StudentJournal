using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using p2021_Koba_B_O_Ind_2._2new;
using System.Collections;
using System.IO;

namespace p2022_Koba_B_O_Ind_2._3
{
    public partial class Form1 : Form
    {
        private List<Student> mylist;
        private int counter = 0;
        private int index = -1;
        private string path = @"..\..\..\WinForms_Students.txt";
        private void Form_init(Student student)
        {
            firstname_textbox.Text = student.firstname;
            middlename_textbox.Text = student.middlename;
            lastname_textbox.Text = student.lastname;
            date_textBox.Text = ($"Day:{student.birth_date.Day} Mounth:{student.birth_date.Month} Year:{student.birth_date.Year}");
            Id_textBox.Text = ($"{student.student_id}");
            facultet_textBox.Text = student.facultet;
            group_textBox.Text = student.group;
        }
        private void Form_reset()
        {
            firstname_textbox.Clear();
            firstname_textbox.Clear();
            firstname_textbox.Clear();
            middlename_textbox.Clear();
            lastname_textbox.Clear();
            date_textBox.Clear();
            Id_textBox.Clear();
            facultet_textBox.Clear();
            group_textBox.Clear();
        }
        private Student Student_init()
        {
            Student student_init = new Student();
            student_init.firstname = firstname_textbox.Text;
            student_init.middlename = middlename_textbox.Text;
            student_init.lastname = lastname_textbox.Text;
            try
            {
                student_init.birth_date = DateTime.Parse(date_textBox.Text);
            }
            catch
            {
                MessageBox.Show("Ви не вказали дату");
            }
            try
            {
                student_init.student_id = Int32.Parse(Id_textBox.Text);
            }
            catch
            {
                MessageBox.Show("Ви не вказали Id");
            }
            student_init.facultet = facultet_textBox.Text;
            student_init.group = group_textBox.Text;
            return student_init;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_button_MouseClick(object sender, MouseEventArgs e)
        {
            Student add_student = Student_init();
            mylist.Add(add_student);
            counter++;
            index++;
            counter_textBox.Text = counter.ToString();
            Form_reset();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mylist = new List<Student>();
        }

        private void next_element_button_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                index++;
                Student next_student = mylist.ElementAt(index);
                Form_init(next_student);
            }
            catch
            {
                MessageBox.Show("Немає наступного елементу");
                index--;
                Student next_student = mylist.ElementAt(index);
                Form_init(next_student);
            }
        }
        private void previous_element_button_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                index--;
                Student previous_student = mylist.ElementAt(index);
                Form_init(previous_student);
            }
            catch
            {
                MessageBox.Show("Немає попереднього елементу");
                index++;
                Student previous_student = mylist.ElementAt(index);
                Form_init(previous_student);
            }
        }

        private void save_button_MouseClick(object sender, MouseEventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (var el in mylist)
                {
                    sw.WriteLine(el.ToString());
                }
                sw.Close();
            }
        }
    }
}
