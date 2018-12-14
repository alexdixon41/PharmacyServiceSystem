using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    class Medicine
    {
        private string date;            //date when the containing prescription was created
        private string name;            //name of the medicine
        private int quantity;           //quantity of medicine units
        private string dosage;          //total amount of medicine
        private string route;           //how the medicine is taken
        private string instructions;    //specific instructions on how to use the medicine
        private int prescriptionID;     //id of the containing prescription

        //public properties
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
        public string Dosage
        {
            get
            {
                return dosage;
            }

            set
            {
                dosage = value;
            }
        }
        public string Route
        {
            get
            {
                return route;
            }

            set
            {
                route = value;
            }
        }
        public string Instructions
        {
            get
            {
                return instructions;
            }

            set
            {
                instructions = value;
            }
        }
        public int PrescriptionID
        {
            get
            {
                return prescriptionID;
            }

            set
            {
                prescriptionID = value;
            }
        }
        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}
