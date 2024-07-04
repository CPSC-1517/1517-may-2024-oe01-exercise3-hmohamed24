namespace BookSystem
{
    public class Book
    {
        private Author _author;
        private string _isbn;
        private int _publishYear;
        private string _title;

        public Author Author
        {
            get { return _author; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Author required.");
                }

                _author = value;
            }
        }

        public GenreType Genre { get; set; }

        public string ISBN
        {
            get { return _isbn; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("ISBN required.");
                }

                _isbn = value;
            }
        }

        public int PublishYear
        {
            get { return _publishYear; }
            set
            {
                if (value <= 999 || value >= 10000)
                {
                    throw new FormatException("Publish year required format yyyy.");
                }

                _publishYear = value;
            }
        }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title required.");
                }

                _title = value;
            }
        }

        public int TotalReviews
        {
            get { return Reviews.Count; }
        }

        public Book(string isbn, string title, int pubishYear, Author author, GenreType genre, List<Review> reviews)
        {
            ISBN = isbn;
            Title = title;
            PublishYear = pubishYear;
            Author = author;
            Genre = genre;
            Reviews = reviews;
        }

        public void AddReview(string isbn, Review? review)
        {
            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException("ISBN required.");
            }
            else
            {
                if (review == null)
                {
                    throw new NullReferenceException("Review required.");
                }
                else
                {
                    if (isbn != review.ISBN)
                    {
                        throw new ArgumentException("Did not match Book ISBN.");
                    }
                    else
                    {
                        //if (Reviews.Where(r => r.ISBN == isbn && r.Reviewer.Email == review.Reviewer.Email).Any())
                        //{
                        //    throw new ArgumentException($"{review.Reviewer.LastName}, {review.Reviewer.FirstName} review exists.");
                        //}
                        //else
                        //{
                        Reviews.Add(review);
                        //}
                    }
                }
            }
        }
    }
}
