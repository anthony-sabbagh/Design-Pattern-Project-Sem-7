using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Memento_Pattern.Memento
{
    public class PersonMemento
    {
       
        public string Username { get; private set; }
        public string Password { get; private set; }

        public PersonMemento( string username, string password)
        {
            
            Username = username;
            Password = password;
        }
    }
}

