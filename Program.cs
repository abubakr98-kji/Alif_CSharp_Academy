using System;




namespace OOP2
{
    class Program
    {
        
        // public string authorName = Console.ReadLine();
    
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            string content = Console.ReadLine();
            
            
            Book myBook = new Book();

            Author myAuthor = new Author(author);

            Title myTitle = new Title(title);

            Content myContent = new Content(content);

            Console.WriteLine("By Book:");
            myTitle.Show();
            myAuthor.Show();
            myContent.Show();


        }
    }
}