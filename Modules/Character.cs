namespace api_simpsons.Modules
{
   public class Character
   {
       string name;
       string secondName;
       string lastName;
       int age;
       int height;
       int weight;
       string occupation;
       string birthDate;
       string photo;
       string description; 

       public Character(){}

        public Character(string name, string secondName, string lastName, int age, int height, int weight, string occupation, string birthDate, string photo, string description)
        {
            this.name = name;
            this.secondName = secondName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.occupation = occupation;
            this.birthDate = birthDate;
            this.photo = photo;
            this.description = description;
        }

        public string Name { get => name; set => name = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Photo { get => photo; set => photo = value; }
        public string Description { get => description; set => description = value; }
    }
}