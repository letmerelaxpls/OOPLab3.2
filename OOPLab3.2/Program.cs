using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3._2
{
     class Book
    {
        public Title Title { get; set; } = new Title() { Content = Console.ReadLine() };
        public Content Content { get; set; } = new Content() { Content = Console.ReadLine() };
        public Author Author { get; set; } = new Author() { Content = Console.ReadLine() };
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Title.Show();

            Console.ForegroundColor = ConsoleColor.Red;
            Author.Show();

            Console.ForegroundColor = ConsoleColor.White;
            Content.Show();   
        }
    }
    internal class Title : BaseContent
    {
        public void Show() => Show("Title");
    }
    internal class Author : BaseContent
    {
        public void Show() => Show("Author");
    }
    internal class Content : BaseContent
    {
        public void Show() => Show("Content");

    }
    internal class BaseContent
    {
        public string Content { get; set; }
        protected void Show(string heading) => Console.WriteLine($"{heading}: {Content}");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            
            book.Show();
            
        }
    }
}
