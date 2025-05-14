
namespace Access_Modifiers_ReadOnly
{
    public class User
    {
        public string Username { get; private set; }
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age mənfi ola bilməz.");
                _age = value;
            }
        }
        private string _password;
        public string Password
        {
            get => _password;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Password bos ola bilmez.");
                if (value.Length < 8)
                    throw new ArgumentException("Uzunlugu 8-den kicik ola bilmez");
                if (!HasUpperCase(value))
                    throw new ArgumentException("Icinde en az bir boyuk herf olmalidir");
                if (!HasDigit(value))
                    throw new ArgumentException("Icinde en az bir reqem olmalidir");

                _password = value;
            }
        }
        public User(string username, int age, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username bos olmamalidir");

            Username = username;
            Age = age;
            Password = password;
        }
        private bool HasUpperCase(string input)
        {
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }

        private bool HasDigit(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

    }
}
