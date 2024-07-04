using System.Globalization;
using System.Text.RegularExpressions;

namespace BookSystem
{
    public class Reviewer
    {
        private string _email;
        private string _firstName;
        private string _lastName;
        private string _organization;

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Email is required.");
                }

                string regex = @"^[^@\s]+@[^@\s]+\.(ca|com|net|org|gov)$";
                                
                if (!Regex.IsMatch(value, regex, RegexOptions.IgnoreCase))
                {
                    throw new ArgumentException("Invalid email.");
                }

                _email = value;
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.Trim()))
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
                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Last name is required.");
                }

                _lastName = value;
            }
        }

        public string Organization
        {
            get { return _organization; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Organization is required.");
                }

                _organization = value;
            }
        }

        public string ReviewerName
        {
            get { return FirstName + " " + LastName; }
        }

        public Reviewer(string firstName, string lastName, string email, string organization)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Organization = organization;
        }

        public override string ToString()
        {
            return $"{FirstName},{LastName},{Email},{Organization}";
        }
    }
}
