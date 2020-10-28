using System;
using System.Collections.Generic;

namespace Parsen_eines_Klammernausdrucks
{
    public class Stack
    {
        //Eigenschften / Attribute
        private int _MaxLength = 0;
        public int MaxLength
        {
            get => _MaxLength;
            set
            {
                if (value >= 0)
                {
                    _MaxLength = value;
                }
                else
                    throw new ArgumentOutOfRangeException($"{nameof(value)} cant be lower than 0.");
            }
        }

        private List<char> Elements;
        
        //Konstruktor
        public Stack()
        {
            Elements = new List<char>();
        }

        // Methoden
        public bool Push(char value)
        {
            if (Elements.Count < MaxLength)
                Elements.Insert(0, value);
            else
                return false;
            return true;
        }
        public char Pop()
        {
            if (Elements.Count <= 0)
                return ' ';
            char value = Elements[0];
            Elements.RemoveAt(0);
            return value;
        }
        public int GetCurrLenght()
        {
            return Elements.Count;
        }
    }
}
