using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Memento_Pattern.Originator;
using Project.Memento_Pattern.Memento;

namespace Project.Memento_Pattern.Caretaker
{
    public class PersonCaretaker
    {
        readonly Stack<PersonMemento> _mementos = new Stack<PersonMemento>();

        public PersonMemento GetMemento()
        {
            return _mementos.Pop();
        }

        public void Add(PersonMemento memento)
        {
            _mementos.Push(memento);
        }
    }
}
