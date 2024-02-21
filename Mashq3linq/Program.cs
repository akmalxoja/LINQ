using Mashq3linq;

List<Bugalter> bugalters = new List<Bugalter>
{
    new Bugalter {id = 1, name = "John", Programminglanguage = "C#"},
    new Bugalter {id = 2, name ="Jack", Programminglanguage = "Phyton"},
    new Bugalter {id = 3, name = "Bob", Programminglanguage = "C#"}

};

List<ProgrammingLanguage> languages = new List<ProgrammingLanguage>
{
    new ProgrammingLanguage{Id = 1, Name = "C#"},
    new ProgrammingLanguage{Id = 2, Name = "Phyton"},
    new ProgrammingLanguage{Id = 3, Name = "Java"}
};


var result = bugalters.Where(p => p.Programminglanguage == "C#");

Console.WriteLine("C# ni biladigan bugalterlar:");

foreach (var bugalter in result)
{
    Console.WriteLine($"{bugalter.id}, {bugalter.name}");
}
