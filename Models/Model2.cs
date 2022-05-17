namespace Appl.Models
{
    public class Model2
    {
        public Model2(ICollection<string> firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public ICollection<string> FirstName { get; set; }
        public string LastName { get; set; }
    }
}
