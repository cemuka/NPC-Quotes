using System;
using System.Collections.Generic;

public static class NPC
{
    public static Entity GetRandom()
    {
        var random = new Random();
        int randomIndex = random.Next(0, _entities.Count);
        return _entities[randomIndex];
    }

    public static List<Entity> GetAll()
    {
        return new List<Entity>(_entities);
    }

    private static List<Entity> _entities = new List<Entity>()
    {
        new Entity("Ned",           "Winter is coming..."),
        new Entity("Goblin",        "Time is money my friend."),
        new Entity("Druid",         "I'm awake... I'm awake."),
        new Entity("Cowboy",        "It's high noon"),
        new Entity("Don Corleone",  "I'm going to make him an offer he can't refuse"),
        new Entity("Travis",   "You talkin' to me?"),
        new Entity("Guard",   "Stop right there!"),
        new Entity("Darth Vader",   "Luke, I am your father"),
        new Entity("Jules Winnfield",   "Say what again. SAY WHAT again! And I dare you, I double dare you motherfucker! Say what one more time."),
        new Entity("Hodor",   "Hodor..."),
        new Entity("King Leonidas",   "This is SPARTAAAAAAAAAA"),
        new Entity("Ruby Rhod",   "Corban! Baby!")
    };
}

public class Entity
{
    public string name;
    public string quote;

    public Entity(string name, string quote)
    {
        this.name = name;
        this.quote = quote;
    }
}
