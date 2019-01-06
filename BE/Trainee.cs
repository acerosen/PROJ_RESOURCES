using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee
    {
        public int ID { get; set; } // Teudat Zehut
        public string FirstName { get; set; }  // First Name
        public string FamilyName { get; set; }  // Last Name
        public string Gender { get; set; }  // Gender
        public int PhoneNum { get; set; }  // Cellphone Number
        public string Address { get; set; } //Address
        public Date Birthday { get; set; }  // Date of Birth
        public string Model { get; set; } //Car Model
        public string GearType { get; set; } //Type of Transmission (Manual or Automatic)
        public string School { get; set; } //Name of Driving School
        public string TeacherName { get; set; } //Name of Teacher
        public int LessonAMT { get; set; } //Amount of Lessons
    }
}
