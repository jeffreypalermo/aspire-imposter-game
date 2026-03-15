namespace ImposterGame.Services;

public class ChameleonTopicService
{
    // Each topic has exactly 16 words for the 4x4 grid (rows A-D, columns 1-4)
    private readonly Dictionary<string, List<string>> _topics = new()
    {
        ["Animals"] = new()
        {
            "Lion", "Tiger", "Elephant", "Dolphin",
            "Eagle", "Penguin", "Giraffe", "Shark",
            "Wolf", "Gorilla", "Peacock", "Kangaroo",
            "Panda", "Crocodile", "Owl", "Cheetah"
        },
        ["Countries"] = new()
        {
            "USA", "France", "Japan", "Brazil",
            "Germany", "India", "Australia", "Canada",
            "Mexico", "Italy", "China", "Spain",
            "Russia", "Egypt", "Nigeria", "Argentina"
        },
        ["Foods"] = new()
        {
            "Pizza", "Sushi", "Tacos", "Burger",
            "Pasta", "Curry", "Steak", "Salad",
            "Ramen", "Pancakes", "Soup", "Sandwich",
            "Waffles", "Paella", "Dumplings", "Lasagna"
        },
        ["Movies"] = new()
        {
            "Titanic", "Avatar", "Inception", "Frozen",
            "Jaws", "Grease", "Matrix", "Bambi",
            "Rocky", "Shrek", "Alien", "Braveheart",
            "Clueless", "Gladiator", "Mulan", "Toy Story"
        },
        ["Musical Instruments"] = new()
        {
            "Piano", "Guitar", "Violin", "Drums",
            "Trumpet", "Flute", "Cello", "Harp",
            "Saxophone", "Clarinet", "Trombone", "Oboe",
            "Banjo", "Ukulele", "Bass", "Xylophone"
        },
        ["Occupations"] = new()
        {
            "Doctor", "Teacher", "Chef", "Pilot",
            "Lawyer", "Nurse", "Firefighter", "Astronaut",
            "Scientist", "Architect", "Journalist", "Carpenter",
            "Veterinarian", "Accountant", "Engineer", "Artist"
        },
        ["Sports"] = new()
        {
            "Football", "Basketball", "Soccer", "Tennis",
            "Baseball", "Hockey", "Volleyball", "Golf",
            "Swimming", "Boxing", "Cycling", "Gymnastics",
            "Rugby", "Surfing", "Skiing", "Wrestling"
        },
        ["Superheroes"] = new()
        {
            "Superman", "Batman", "Spider-Man", "Wonder Woman",
            "Iron Man", "Thor", "Captain America", "Black Panther",
            "Hulk", "Flash", "Aquaman", "Green Lantern",
            "Wolverine", "Storm", "Black Widow", "Doctor Strange"
        },
        ["TV Shows"] = new()
        {
            "Friends", "Seinfeld", "The Office", "Breaking Bad",
            "Game of Thrones", "Lost", "Survivor", "Jeopardy",
            "Grey's Anatomy", "CSI", "Stranger Things", "The Crown",
            "Yellowstone", "Ted Lasso", "Succession", "Mandalorian"
        },
        ["Annika"] = new()
        {
            "Dancing", "Sewing", "Singing", "Tennis",
            "Legos", "Clarinet", "Bass", "Worship Band",
            "Squishmallow", "Middle School", "Blonde", "Beautiful",
            "Creative", "Kind", "Fashionable", "Musical"
        }
    };

    public List<string> GetTopics() => _topics.Keys.OrderBy(k => k).ToList();

    public List<string> GetWords(string topic)
    {
        if (!_topics.ContainsKey(topic))
        {
            throw new ArgumentException($"Topic '{topic}' not found");
        }
        return _topics[topic];
    }
}
