using System;

namespace ClassLibraryStudent
{
    public class Person
    {
        private string _name;
        private string _address;
        private GenderType _genderType;


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

        public string Address
        {
            // Kaster en exception hvis der ikke er givet en værdi
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
        }


        public enum GenderType
        { Male, Female}

        //enum der indeholder 2 typer

        public GenderType GenderTypeMF
        {
            get { return _genderType; }
            set { _genderType = value; }
        }
        
    }
}
