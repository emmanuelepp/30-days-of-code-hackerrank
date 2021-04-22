class MyBook : Book
        {
            readonly int price = 0;

            public MyBook( string title, string author, int price) : base(title,author)
            {
                this.price = price;
            }

            public override void Display() 
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Price: " + price);
            }
        }
