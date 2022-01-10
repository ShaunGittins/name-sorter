namespace name_sorter
{
    public class Person
    {
        public string[] FirstNames { get; set; }
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
