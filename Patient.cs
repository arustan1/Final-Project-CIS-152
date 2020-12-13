using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectRustan
{
    class Patient
    {
        /***************************************************************
        * Name        : Patient
        * Author      : Alicia Rustan
        * Created     : 12/11/2020
        ***************************************************************/
        private string name;
        private string ownerName;
        private string type;
        private string condition;

        public Patient()
        {
            Name = "";
            OwnerName = "";
            Type = "";
            Condition = "";
        }

        public Patient(string name, string ownerName, string type, string condition)
        {
            this.Name = name;
            this.OwnerName = ownerName;
            this.Type = type;
            this.Condition = condition;
        }

        public string Name { get => name; set => name = value; }
        public string OwnerName { get => ownerName; set => ownerName = value; }
        public string Type { get => type; set => type = value; }
        public string Condition { get => condition; set => condition = value; }
    }
}
