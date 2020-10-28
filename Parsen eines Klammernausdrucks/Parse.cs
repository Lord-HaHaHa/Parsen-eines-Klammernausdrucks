using System.Diagnostics;

namespace Parsen_eines_Klammernausdrucks
{
    public partial class MainWindow
    {
        public class Parse
        {
            public bool ParseCharSet(char[] chars)
            {
                Stack open = new Stack();
                open.MaxLength = chars.Length;
                char last;
                foreach(char curr in chars)
                {
                    Trace.Write(curr);
                    switch (curr)
                    {   
                        //Push von öffnungsklammern
                        case '(':
                        case '[':
                        case '{':
                            open.Push(curr);
                            break;
                        
                        //Pop von schließungsklammern
                        case ')':
                        case ']':
                        case '}':
                            last = open.Pop();
                            char should = ' ';
                            switch(last)
                            {
                                case '(':
                                    should = ')';
                                    break;
                                case '[':
                                    should = ']';
                                    break;
                                case '{':
                                    should = '}';
                                    break;
                            }
                            if (should != curr)
                                return false;
                            break;
                    }
                }
                if(open.GetCurrLenght() > 0)
                    return false;
                return true;
            }
        }
    }
}
