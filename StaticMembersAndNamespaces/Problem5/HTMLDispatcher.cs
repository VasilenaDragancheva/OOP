using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    public static class HTMLDispatcher
    {
        private const string URL = "url";
        private const string IMG = "img";
        private const string INPUT = "input";
        private const string SRC = "src";
        private const string ALT = "alt";
        private const string TITLE = "title";
        private const string TEXT = "text";
        private const string TYPE = "type";
        private const string NAME = "name";
        private const string VALUE = "value";


       public static string CreateImage(string source, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder(IMG);
            img.AddAttributes(SRC, source);
            img.AddAttributes(ALT, alt);
            img.AddAttributes(TITLE, title);
            return img.ToString();

        }
      
        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder(INPUT);
            input.AddAttributes(TYPE, type);
            input.AddAttributes(NAME, name);
            input.AddAttributes(VALUE, value);

            return input.ToString();
        }
    }
}
