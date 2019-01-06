using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {
        public int ID { get; set; } //Test ID
        public int TesterID { get; set; } //Teudat Zehut of Tester
        public int TraineeID { get; set; } //Teudat Zehut of Trainee
        public Date Date { get; set; } //Date of Test
        public int Hour { get; set; } //Time of Test (always one hour) Ranging from 0900-1500
        public string Address { get; set; } //Place of Test
        public Array Grade { get; set; } //Array of Boolean operators determining Grade of Test
        public string Comment { get; set; } //Tester's Comment on Test
    } 
}
