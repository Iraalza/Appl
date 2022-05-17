namespace Appl.Models
{
    public class Model1
    {
        public Model1(ICollection<string> name, int age)
        {
            Name = name;
            Age = age;
        }

        public ICollection<string> Name { get; set; }
        public int Age { get; set; }
    }
}
