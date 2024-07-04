using System.Text.RegularExpressions;

namespace BookSystem
{
    public class Author
    {
        private string _contactUrl;
        private string _firstName;
        private string _lastName;
        private string _residentCity;
        private string _residentCountry;

        public string ContactUrl
        {
            get { return _contactUrl; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Contact url is required.");
                }

                //string regex = @"^[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$";

                //if (!Regex.IsMatch(value, regex, RegexOptions.IgnoreCase))
                //{
                //    throw new ArgumentException("Invalid contact url and is required");
                //}

                _contactUrl = value;
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name is required.");
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name is required.");
                }

                _lastName = value;
            }
        }

        public string AuthorName
        {
            get { return LastName + ", " + FirstName; }
        }

        public string ResidentCity
        {
            get { return _residentCity; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Resident city is required.");
                }

                _residentCity = value;
            }
        }

        public string ResidentCountry
        {
            get { return _residentCountry; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Resident country is required.");
                }

                _residentCountry = value;
            }
        }

        public Author(string firstName, string lastName, string contactUrl, string residentCity, string residentCountry)
        {
            FirstName = firstName;
            LastName = lastName;
            ContactUrl = contactUrl;
            ResidentCity = residentCity;
            ResidentCountry = residentCountry;
        }

        public override string ToString()
        {
            return $"{FirstName},{LastName},{ContactUrl},{ResidentCity},{ResidentCountry}";
        }
    }
}
