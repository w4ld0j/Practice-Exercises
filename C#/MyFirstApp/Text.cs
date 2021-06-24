using System;

namespace MyFirstApp
{
    public class Text : PresentationObject
        {
            public int Fontsize { get; set; }
            public string FontName { get; set; }

            public void AddHyperlink(string url)
            {
                System.Console.WriteLine("We added a link to " + url);
            }
        }
}