
namespace Access_Modifiers_ReadOnly
{
    public class Student : Person
    {
        private int point;
        public int Point
        {
            get => point;
            set
            {
                if (value <= 0 || value >= 100)
                    throw new ArgumentException("Point deyeri minimum 0 maximum 100 ola biler.");
                point = value;
            }
        }
        public Student(string name, string surname, int age, int point)
        : base(name, surname, age)
        {
            Point = point;
        }
    }
}
