using System;
using System.Text.RegularExpressions;

class Person
    {
        private string name;
        private int age;
        private string email;

        public const string emailPattern = @"(\w+)[@](\w+)[.](\w+)";

        public string Name 
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                
                this.name = value;           
            } 
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be a number between 1-100");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (!Regex.IsMatch(value,emailPattern) || value== "")
                {
                    throw new ArgumentOutOfRangeException("Invalid email!");
                }
                this.email = value;
            }
        }

        public Person(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, string email) : this(null,0)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

    public override string ToString()
    {
        if (this.Email == null)
        {
            return string.Format("And the winner is:\nName: {0}\nAge: {1}\n", this.Name, this.Age);
        }
       
        return string.Format("And the winner is:\nName: {0}\nAge: {1}\nEmail:{2}\n", this.Name, this.Age, this.Email);
    }
}

