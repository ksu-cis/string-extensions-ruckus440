using System;
using System.Collections.Generic;
using System.Text;


namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static int WordCount(this String str)
        {

            return str.Split(new char[] { ' ', '.', '?', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string Capitalize(this String str)
        {
            string first = str[0].ToString().ToUpper();
            return first + str.Substring(1);
        }

        public static void Decapitilize(this String str)
        {
            //Doens't work
            string first = str[0].ToString().ToLower();
            str = first + str.Substring(1);
        }

        public static String Titleize(this String title)
        {
            List<string> articles = new List<string>()
            {
                "a",
                "an",
                "the"
            };
            string first;
            List<string> parts = new List<string>(title.Split(""));
            List<string> result = new List<string>();
            if (articles.Contains(parts[0].ToLower()))
            {
                parts.RemoveAt(0);
                parts.Add(", ");
                //parts.Add(first);
                first = parts[0];
                while (articles.Contains(first.ToLower()))
                {
                    //parts.Remove();
                    //parts.Add();

                }
            }
            return parts.ToString();

        }
    }
}
