namespace ConsoleEqualsBook10nov2023
{
    internal class Book10nov2023
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        protected double price;

        virtual public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return $"{Title} - {Author} ({ISBN}) {Price}";
        }

        public override bool Equals(object obj)
        {
            bool areEqual = false;

            if (this.ISBN == ((Book10nov2023)obj).ISBN)
            {
                areEqual = true;
            }

            return areEqual;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ISBN);
        }

        public static Book10nov2023 TelOp(Book10nov2023 b1, Book10nov2023 b2)
        {
            Book10nov2023 omnibus = new Book10nov2023();
            omnibus.Author = b1.Author + ", " + b2.Author;
            omnibus.Title = "Omnibus van " + omnibus.Author;
            omnibus.Price = (b1.Price + b2.Price) / 2;
            return omnibus;
        }
    }
}
