namespace Domain;

public class Dog
{
    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get; set; } 

    private int _age;
    public int Age
    {
        get 
        {
            return _age; 
        }
        
        set
        {
            if ( value < 0 || value > 30)
            {
                throw new ArgumentOutOfRangeException("Age must be between 0 and 30");
            }
            _age = value;
        }
    }
        public string Bark()
        {
            return "Woof!";
        }

        public string ShowHumanAge()
        {
            return $"{Name} is {HumanAge()} years old in human years.";
        }

        private int HumanAge()
        {
            return Age * 7;
        }

}
