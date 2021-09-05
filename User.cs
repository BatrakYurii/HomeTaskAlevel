namespace Master
{
    public class User
    {

        public User(int id, string name, string gender, uint age)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
        }

        public int Id { get; init; }

        public string Name { get; init; }

        public string Gender { get; set; }

        public uint Age { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Gender} {Age}";
        }
    }
}
