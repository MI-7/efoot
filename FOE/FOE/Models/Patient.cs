using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOE.Models
{
    public class Patient
    {
        public int id;
        public String name;
        public String phone;
        public String gender;

        public Image foot_back;
        public Image foot_front;
        public Image foot_innertleft;
        public Image foot_innerright;
        public Image foot_bottom;

        public Patient(int id, String name, String phone, String gender)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.gender = gender;
        }
    }
}
