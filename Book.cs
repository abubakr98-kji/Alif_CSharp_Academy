using System;

namespace OOP2
{
    /*Start of Book*/
    public class Book
    {
        
        public Book()
        {

            
        }
    }
    /*End of Book*/
    
    /*Begining of Title*/
    public class Title
    {
        public string titleText { get; set; }
        public Title(string _titleName)
        {
            titleText = _titleName;
        }
        public void Show()
        {
            Console.WriteLine($"My Books Title name is: {titleText}");
        }
        
        
    }
    /*End of Title*/
    
    public class Author
    {
        public string authorName { get; set; }
        public Author(string _authorName)
        {
            authorName = _authorName; 
        }

        public void Show()
        {
            Console.WriteLine($"Mt Books author name is: {authorName}");    
        }
    }
    
    /*Start of Content*/
    public class Content
    {
        public string contentText { get; set; }
        public Content(string _content)
        {
            contentText = _content;
        }

        public void Show()
        {
            Console.WriteLine($"Context of book: {contentText}");
        }
    }
  /*End of Content*/
}