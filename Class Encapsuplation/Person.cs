using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_Encapsuplation
{
    internal class Person
    {
		private int _phoneNumber;
        private string _fullName;
        private byte _age;



        public Person(string fullName,int phoneNumber,byte age)
        {
            this._fullName = fullName;
			this._phoneNumber = phoneNumber;
			this._age = age;
        }

        public int PhoneNumber
		{
			get 
			{
				return _phoneNumber; 
			}
			set 
			{ 
				if (value > 0)
				{
                    _phoneNumber = value;
                }
				
			}
		}

		

		public string FullName
		{
			get 
			{
				return _fullName;
            }
            set 
			{
                string[] nameParts = value.Trim().Split(' '); // INTERNETDEN KOMEK ALDIM 

                if (nameParts.Length >= 2 && !string.IsNullOrWhiteSpace(nameParts[1])) 
                {
                    _fullName = value;
                }
            
            }
		}

		

		public byte Age
		{
			get 
			{ 
				return _age;
			}
			set
			{ 
				if(value > 0 && value < 180) 
				{ 
					_age = value;
				}
				 
			}
		}


	}
}
