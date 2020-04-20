using System;
using System.Collections.Generic; //dictionary uses this class

namespace oop
{
    public class HtttpCookie
    {
        //initialize a dictionaty of key and value pairs types of string
        private readonly Dictionary<string, string> _dictionary;

        public HtttpCookie()
        {
            _dictionary = new Dictionary<string, string>(); // this can also be set in the field above as seen in Shop class.
        }

        //declare an indexer
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value;  }
        } 
    }
}
