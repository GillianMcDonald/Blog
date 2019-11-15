using System;
using System.Collections. Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace Blog.Models
{
    public class User
    {
        
        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (value.Length > 20)
                {
                    Console.WriteLine("Error! First Name must be less than 21 characters!");
                }
                else
                {
                    _FirstName = value;
                }
            }
        }

        private string _LastName;

        public string LastName
        {
            get { return _LastName;}

            set
            {
                if (value.Length > 20)
                {
                    Console.WriteLine("Error! Last Name must be less than 21 characters!");
                }
                else
                {
                    _LastName = value;
                }
            }
        }

        private int _UserID; 
        
        public int UserID
        {
            get { return _UserID; }
            set {_UserID = value;}
        }
        
        private string _UserName; 
        
        public string UserName
        {
            get { return _UserName; }
            set
            {
                if (value.Length > 9)
                {
                    Console.WriteLine("Error! UserName must be less than 10 characters!");
                }
                else
                {
                    _UserName = value;
                }
            }
        }
        
        private string _Email; 
        
        public string Email
        {
            get { return _Email; }
            set
            {//need to change the checking criteria here 
                if (value.Length > 50)
                {
                    Console.WriteLine("Error! Email Address must contain and @ and a .!");
                }
                else
                {
                    _Email = value;
                }
            }
        }
        
        private string _Password;
        
        public string Password
        {
            get { return _Password; }
            set
            {
                if (value.Length < 8)
                {
                    Console.WriteLine("Error! Password must be at least 8 characters!");
                }
                else
                {
                    _Password = value;
                }
            }
        }

       
        public List<Blog> Blogs { get; set; }
        
//        public User(string firstname, string lastname, int userid, string username, string email, string password)
//        {
//            FirstName = firstname;
//            LastName = lastname;
//            UserID = userid;
//            UserName = username;
//            Email = email;
//            Password = password;
//        }

    }
}