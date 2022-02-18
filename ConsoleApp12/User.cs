using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
    public class UserController
    {
        Random random = new Random(); 
        public List<User> Users { get; set; }

        public  UserController ()
        {
            Users = new List<User>()
            {
                new User { Name ="иван" , 
                    Age= random.Next
                (16,22)
                },

                  new User { Name ="Денис" ,
                    Age= random.Next
                (16,22)
                },

                    new User { Name ="Лена" ,
                    Age= random.Next
                (16,22)
                },

                      new User { Name ="Петя" ,
                    Age= random.Next
                (16,22)
                },
            };
        }
    }
}
