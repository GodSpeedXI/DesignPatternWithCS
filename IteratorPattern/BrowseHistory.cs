using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatternPractice.MementoPattern;

namespace DesignPatternPractice.IteratorPattern
{
    /// <summary>
    /// Iterator Pattern is a design pattern handling obj history that similar to Momento Pattern.
    /// The difference is Iterator Pattern can repeat to find the obj inside the List 
    /// </summary>
    public class BrowseHistory
    {
        private List<string> _urlList = new List<string>();
        public BrowseHistory() { }
        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        public void push(string url)
        {
            _urlList.Add(url);
        }

        public string pop()
        {
            var lastIndex = _urlList.Last();
            _urlList.Remove(lastIndex);
            return lastIndex;
        }

        /// <summary>
        /// This is nested class for BrowseHistory class implementation.
        /// Another outside class can't access to modify this class.
        /// </summary>
        public class ListIterator : IIterator<string>
        {
            private readonly BrowseHistory _history;
            private int _index = 0;

            public ListIterator(BrowseHistory history)
            {
                _history = history;
            }
            public bool HasNext()
            {
                return (_index < _history._urlList.Count);
            }

            public string Current()
            {
                return _history._urlList[_index];
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}
