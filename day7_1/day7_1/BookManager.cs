using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_1
{
    struct Book
    {
        public long Isbn;
        public string BookName;
        public string Author;
        public int Price;

        public Book(long isbn, string bookName, string author, int price)
        {
            this.Isbn = isbn;
            this.BookName = bookName;
            this.Author = author;
            this.Price = price;
        }
    }

    internal class BookManager
    {
        private static int BookNumber;
        private List<Book> books;
        private long Isbn;
        private string BookName;
        private string Author;
        private int Price;

        public BookManager(long isbn, string bookName, string author, int price) 
        {
            BookNumber = 0;
            this.Isbn = isbn;
            this.BookName = bookName;
            this.Author = author;
            this.Price = price;
            books = new List<Book>();
            books.Add(new Book(this.Isbn, this.BookName, this.Author, this.Price));
        }

        public BookManager(Book book)
        {
            this.Isbn = book.Isbn;
            this.BookName = book.BookName;
            this.Author = book.Author; 
            this.Price = book.Price;
            books = new List<Book>();
            books.Add(book);
        }

        public BookManager()
        {
            books = new List<Book>();
        }

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void PrintBookInfo(double Rate)
        {
            Console.WriteLine($"{BookNumber++}번째 책 정보 : 할인율({Rate}%)");
            Console.WriteLine($"ISBN : {this.Isbn}");
            Console.WriteLine($"제 목 : {this.BookName}");
            Console.WriteLine($"저 자 : {this.Author}");
            Console.WriteLine($"정 가 : {this.Price:N0} 원");
            Console.WriteLine($"할인가({Rate*100}%): {CalcPrice(Rate):N0}원\n");
        }

        private double CalcPrice(double Rate)
        {
            return this.Price - (this.Price * Rate);
        }
    }
}
