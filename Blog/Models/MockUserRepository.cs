using System;
using System.Collections. Generic; 
using System.Linq; 
using System.Threading.Tasks;

namespace Blog.Models
{
    public class MockUserRepository: IUserRepository
    {
        public IEnumerable<User> AllUsers =>
            new List<User>
            {
                new User
                {
                    FirstName = "Jody", LastName = "Smith", UserID = 1, UserName = "JDog", Email = "Jody@Jody.com",
                    Password = "JodyMcJoderson"
                },
                new User
                {
                    FirstName = "Heather", LastName =  "Smith", UserID =2, UserName =  "HDog", Email = "Heather@Heather.com", 
                        Password = "HeatherMcHeatherson"
                },
                new User
                {
                    FirstName = "Jody", LastName = "Smith", UserID =3,  UserName = "HDog", Email = "Hammad@Hammad.com",
                Password = "HammadMcHammerson" 
                }
            };
    }
}

