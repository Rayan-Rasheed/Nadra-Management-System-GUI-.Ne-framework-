using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadraManagementGUI.BL
{
    public class citizen
    {
        private string name;
        private string lastname;
        private string gender;
        private string city;
        private string cnic;
        private string fatherName;
        private string province;
        private string tempAdress;
        private string permanentAdress;
        private string vaccineName;
        private int dose;
        private int age;
        private int year;
        private int month;
        private int date;
        private int income;
        private double worthTotal ;
        private int tokenNumber;
        public citizen(string name, string lastname, string gender, string city, string cnic, string fatherName, string province, string tempAdress, string permanentAdress, string vaccineName, int dose, int date, int month, int year, int income, double worthTotal)
        {
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.city = city;
            this.cnic = cnic;
            this.fatherName = fatherName;
            this.province = province;
            this.tempAdress = tempAdress;
            this.permanentAdress = permanentAdress;
            this.vaccineName = vaccineName;
            this.dose = dose;
            this.year = year;
            this.month = month;
            this.date = date;
            this.income = income;
            this.worthTotal = worthTotal;

        }
        public citizen(){
            }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastname; set => lastname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string City { get => city; set => city = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string FatherName { get => fatherName; set => fatherName = value; }
        public string Province { get => province; set => province = value; }
        public string Temp_adress { get => tempAdress; set => tempAdress = value; }

        public string PermanentAdress { get => permanentAdress; set => permanentAdress = value; }
        public string VaccineName { get => vaccineName; set => vaccineName = value; }

        public int Dose { get => dose; set => dose = value; }
        public int Age { get => age; set => age = value; }
        public int TokenNumber { get => tokenNumber; set => tokenNumber = value; }

        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public int Date { get => date; set => date = value; }


        public int Income { get => income; set => income = value; }
        public double WorthTotal { get => worthTotal; set => worthTotal = value; }
    }

}
