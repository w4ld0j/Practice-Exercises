namespace MyFirstApp
{
    public class PresentationObject
    {
        public int Width;
        public int Height {get; set;}

        public void Copy()
        {
            System.Console.WriteLine("Object copied to clipboard.");
        }
        public void Duplicate()
        {
            System.Console.WriteLine("Object was duplicated.");
        }

    }
}