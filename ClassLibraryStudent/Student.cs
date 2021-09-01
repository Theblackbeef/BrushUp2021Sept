using System;

namespace ClassLibraryStudent
{
    public class Student : Person
    {
        ///private string _name;
        ///private string _address;
        private int _semester;
        ///private GenderType _genderType;


        /*public string Name
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
        

        }*/

        /*public string Address
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

        public int Semester
        {

            //kaster en exception hvis der er mindre en 1 eller mere end 8 semestre givet.
            get { return _semester; }
            set
            {
                if (value < 1 || value > 8)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _semester = value;
                }
            }
        }

        /*public enum GenderType
        { Male, Female}

        public GenderType GendertypeMF
        {
            get { return _genderType; }
            set { _genderType = value; }
        }
        */

    }
}
