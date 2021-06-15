using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace KataIndividual
{
    public class TextTransform
    {

        public string convertToCame(string text)
        {
            if (text is null)
            {
                throw new ArgumentNullException();
            }

            TextInfo info = new CultureInfo("en-us", false).TextInfo;
            text = info.ToTitleCase(text);
            text = $"{text.First().ToString().ToLowerInvariant()}{text.Substring(1)}";

            return text;
        }
    }
}
