namespace Clases
{
    public class Dog : IDog
    {
        public string Name { get; set; }
        public void Bark()
        {
            Name = "guau";
        }
    }
}