
namespace Access_Modifiers_ReadOnly
{
    public class Person
    {
        private string _name;
        private string _surname;
        public int Age;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name bos ola bilmez.");
                if (value.Length < 3 || value.Length > 30)
                    throw new ArgumentException("Name 3 ile 30 herf arasinda olmalidir");
                if (!char.IsUpper(value[0]))
                    throw new ArgumentException("Name boyuk herf ile baslamalidir.");
                _name = value;
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Surname bos ola bilmez.");
                if (value.Length < 3 || value.Length > 35)
                    throw new ArgumentException("Surname 3 ile 35 herf arasinda olmalidir.");
                if (!char.IsUpper(value[0]))
                    throw new ArgumentException("Surname boyuk herfle baslamalidir.");
                _surname = value;
            }
        }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

    }
}
