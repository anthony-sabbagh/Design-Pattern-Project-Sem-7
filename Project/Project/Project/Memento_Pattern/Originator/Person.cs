using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Memento_Pattern.Memento;

namespace Project.Memento_Pattern.Originator
{
    public class Person
    {
        
        public string Username { get;  set; }
        public string Password { get;  set; }

        public PersonMemento CreateUnDo()
        {
            return new PersonMemento( Username, Password);
        }

        public void UnDo(PersonMemento memento)
        {
            
            Username = memento.Username;
            Password = memento.Password;
        }

        
    }

}
