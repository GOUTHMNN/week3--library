using System;
using System.Collections.Generic;
using System.Text;

namespace library
{
    public class Book
    {
        public string Title;

        public string Author;

        public int ISBN;
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"BookAuthor: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }
    }
}
