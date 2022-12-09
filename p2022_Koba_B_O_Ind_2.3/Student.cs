using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  p2021_Koba_B_O_Ind_2._2new
{
    public class Student
    {
        public Student()
        {
            this.firstname = default;
            this.middlename = default;
            this.lastname = default;
            this.birth_date = default;
            this.student_id = default;
            this.facultet = default;
            this.group = default;
        }
        public Student(string firstname, string middlename, string lastname, DateTime birth_date, int student_id, string facultet, string group)
        {
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
            this.birth_date = birth_date;
            this.student_id = student_id;
            this.facultet = facultet;
            this.group = group;
        }
        public Student(string firstname, string middlename, string lastname)
        {
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
        }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public DateTime birth_date { get; set; }
        public int student_id { get; set; }
        public string facultet { get; set; }
        public string group { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"firstname: {firstname}\n");
            sb.Append($"secondname: {middlename}\n");
            sb.Append($"middlename: {lastname}\n");
            sb.Append($"bitrh date: {birth_date}\n");
            sb.Append($"number of student ticket: {student_id}\n");
            sb.Append($"facultet: {facultet}\n");
            sb.Append($"group: {group}\n");
            return sb.ToString();
        }
    }
}
