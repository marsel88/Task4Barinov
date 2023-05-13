using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Barinov
{
    public class User
    {
        public string name { get; set; }
        public string dataOfBith { get; set; }
        public string age { get; set; }
        public string gender { get; set; }
        public User(string _name, string _dataOfBith, string _age, string _gender)
        {
            this.name = _name;
            this.dataOfBith = _dataOfBith;
            this.age = _age;
            this.gender = _gender;
        }

    }

    
}
