using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class employee
    {
        //fields
        private string name;
        private int id;
        private int age;
        private string job;
        private int year;


        //instantiate
        public employee(string data)
        {
            string[] fields = data.Split('|');
            name = fields[0];
            id = int.Parse(fields[1]);
            age = int.Parse(fields[2]);
            job = fields[3];
            year = int.Parse(fields[4]);
        }

        //print
        public override string ToString()
        {
            return "Name:" + name + "    ID:" + id + "    Age:" + age +
                "   Job:" + job + "  Year:" + year;
        }

    }
}
