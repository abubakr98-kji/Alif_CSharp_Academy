using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;




namespace Entity_Practice_Part_One
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ConnectTo db = new ConnectTo())
            {
                // create t object User
                User user1 = new User() { Name = "Qismat",Age = 23};
                User user2 = new User() { Name = "Akram",Age = 25};
                User user3 = new User() { Name = "Abubakr",Age = 25};

                //add them to DB
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                
                db.Users.Add(user3);
                db.SaveChanges();
                Console.WriteLine("Objects successefully added again");
                db.Users.RemoveRange(user1,user2);
                db.SaveChanges();
                Console.WriteLine("Deleted Akram and Qismat ");
                
            
            }
            
            // getting data from DB
            using (ConnectTo db = new ConnectTo())
            {
                var users = db.Users.ToList();
                Console.WriteLine("Object List: ");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}//{u.Name}//{u.Name}");
                }
            }
            
            // Updating the data in DB
            using (ConnectTo db = new ConnectTo())
            {
                User user = db.Users.FirstOrDefault();
                if (user!=null)
                {
                    user.Name = "Saidulugbek";
                    user.Age = 24;
                    db.Users.Update(user);
                    db.SaveChanges();
                }
                // output data after update
                Console.WriteLine("Data after Updating: ");
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}//{u.Name}--{u.Age}");
                }
            }

            using (ConnectTo db = new ConnectTo())
            {
                // accepting new object
                User user = db.Users.FirstOrDefault();
                if (user!=null)
                {
                    // delete object 
                    db.Users.Remove(user);
                    db.SaveChanges();

                }
                // output of data
                Console.WriteLine("Data after deleting");
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}//{u.Name}//{u.Age}");
                }

            }
            
            
            
            
        }
      
     
    }
    
}