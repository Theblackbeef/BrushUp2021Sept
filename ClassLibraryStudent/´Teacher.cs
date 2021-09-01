using System;

namespace ClassLibraryStudent
{
    public class Teacher : Person
    {
        ///private string _name;
       /// private string _address;
        private int _salary;
       /// private GenderType _genderType;

        /*
        public string Name
        {
            get { return _name;}
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _name = value;
                }

            }


        }
        */
       /*
        public string Address
        {
            get { return _address; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _address = value;
                }
                
            }
        }*/
        
        public int Salary

         // Kaster en exception hvis lærens løn er 0 eller mindre
        {
            get { return _salary; }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _salary = value;
                }
            }
        }
     /*
        public enum GenderType
        { Male, Female}

        public GenderType GendertypeMF
        {
            get { return _genderType; }
            set { _genderType = value; }
        }*/
        
    }
}
