namespace name_sorter
{
    public class Person
    {
        public Person(string fullName)
        {
            FirstNames = fullName[fullName.LastIndexOf(' ', fullName.Length)..];
            LastName = fullName[..fullName.LastIndexOf(' ')].TrimEnd();
        }

        public string FirstNames { get; set; }
        public string LastName { get; set; }

        public string GetFullName
        {
            get
            {
                return string.Join(' ', FirstNames) + ' ' + LastName;
            }
        }
    }
}
