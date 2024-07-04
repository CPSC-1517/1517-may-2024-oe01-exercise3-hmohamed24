using System.Globalization;
using System.Text.RegularExpressions;

namespace BookSystem
{
    public class Review
    {
        private string _author;
        private string _comment;
        private string _isbn;
        private string _reviewer;
        private string _title;

        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Author is required.");
                }

                _author = value;
            }
        }

        public string Comment
        {
            get { return _comment; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Comment is required.");
                }

                _comment = value;
            }
        }

        public string ISBN
        {
            get { return _isbn; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("ISBN is required.");
                }

                _isbn = value;
            }
        }

        public RatingType Rating { get; set; }

        public string Reviewer
        {
            get { return _reviewer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Reviewer is required.");
                }

                _reviewer = value;
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Title is required.");
                }

                _title = value;
            }
        }

        public Review(string isbn, string title, string author, string reviewer, RatingType rating,  string comment)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Reviewer = reviewer;
            Rating = rating;
            Comment = comment;
        }

        public override string ToString()
        {
            return $"{ISBN},{Title},{Author},{Reviewer},{Rating},{Comment}";
        }

        public static Review Parse(string text)
        {
            string[] parts = text.Split(',');

            if (parts.Length != 6)
            {
                throw new FormatException($"String is not expected format, Missing value. {text}");
            }

            return new Review(parts[0],
                              parts[1],
                              parts[2],
                              parts[3],
                              (RatingType)Enum.Parse(typeof(RatingType), parts[4]),
                              parts[5]);
        }
    }
}
