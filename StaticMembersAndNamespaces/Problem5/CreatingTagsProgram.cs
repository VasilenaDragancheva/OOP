using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    public class CreatingTagsProgram
    {
        static void Main(string[] args)
        {
            string img = HTMLDispatcher.CreateImage("smiley.gif", "Picture of a Smile", "Smiley face");
            string  textField = HTMLDispatcher.CreateInput("text", "username", null);
            string radiobuttonMale = HTMLDispatcher.CreateInput("radio", "sex", "male");
            string radiobuttonFemale = HTMLDispatcher.CreateInput("radio", "sex", "female");
            Console.WriteLine(img);
            Console.WriteLine(textField);
            Console.WriteLine(radiobuttonMale);
            Console.WriteLine(radiobuttonFemale);

        }
    }
}
