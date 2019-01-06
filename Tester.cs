using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester
    {
        public int ID { get;  set; } // number of branch
        public string FamilyName { get; set; }  // name of branch
        public string FirstName { get; set; }  // address of the branch
        public date Birthday { get; set; }  // the phone of the branch
        public string Gender { get; set; }  // the name of the branch responsible
        public int PhoneNum { get; set; }  // the number of workers in the branch
        public string Address { get; set; }   //the number of the free delevers 
        public int Experience { get; set; }
        public int MaxTestAmt { get; set; }
        public string Model { get; set; }
        public Array Hours { get; set; }
        public int MaxDist { get; set; }
        public override string ToString()
        {
            return branchNumber + " " + branchName;
        }
    }
}
