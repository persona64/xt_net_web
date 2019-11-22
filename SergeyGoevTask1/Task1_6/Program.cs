using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var FontInfo = Console.ReadLine();
            SaveFontText(FontInfo);
            Console.WriteLine(SaveFontText(FontInfo));
            Console.ReadLine();


        }

        static FontInfo SaveFontText(string font)
        {
            if (font == "italic" || font == "Italic")
            {
                return FontInfo.italic;
            }
            else if(font == "Bold" || font == "bold")
            {
                return FontInfo.bold;
            }
            else if (font == "Underline" || font == "underline")
            {
                return FontInfo.underline;
            }
            else
            {
                return FontInfo.none;
            }
        }
    }

    public enum FontInfo 
    {
        none = 0,
        bold = 1,
        italic = 2,
        underline = 3
    }
}
