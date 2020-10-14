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
        new Entity("Favour Chukwuedo",        "Life is too short; wake up earlier!"),
        new Entity("Favour Chukwuedo",        "No quick fixex; just smart work!"),
        new Entity("Goblin",        "Time is money my friend."),
        new Entity("Druid",         "I'm awake... I'm awake."),
        new Entity("Cowboy",        "It's high noon"),
        new Entity("Don Corleone",  "I'm going to make him an offer he can't refuse"),
        new Entity("Travis",   "You talkin' to me?"),
        new Entity("Guard",   "Stop right there!"),
        new Entity("Darth Vader",   "Luke, I am your father"),
        new Entity("Darth Vader",   "Be careful not to choke on your aspirations, Director"),
        new Entity("Wilhuff Tarkin",   "You may fire when ready"),
        new Entity("HK-47",   "Expletive: Damn it, master, I am an assassination droid... not a dictionary!"),
        new Entity("Kira Carsen",   "Eat Lightsaber, Jerk!"),
        new Entity("Jules Winnfield",   "Say what again. SAY WHAT again! And I dare you, I double dare you motherfucker! Say what one more time."),
        new Entity("Dreadloard", "(phone rings) 'Yes? Argh, for the last time: I'm a DREADlord, not a DRUGlord'."),
        new Entity("Hodor",   "Hodor..."),
        new Entity("King Leonidas",   "This is SPARTAAAAAAAAAA"),
        new Entity("Ruby Rhod",   "Corban! Baby!"),
        new Entity("Youngster Joey", "Remember my super cool Rattata? My Rattata is different from regular Rattata. It's like my Rattata is in the top percentage of Rattatas."),
        new Entity("Guard", "I used to be an adventurer like you. But then I took an arrow into the knee.."),
        new Entity("Peppy", "Do a barrel roll"),
        new Entity("Guard", "No Lollygaggin'"),
        new Entity("Belethor","If I Had A Sister, I'd Sell Her In A Second"),
        new Entity("Barney",   "It's going to be legen... wait for it... Dary! LEGENDARY!"),
        new Entity("Hank Moody",   "A morning of awkwardness is far better then a night of loneliness"),
        new Entity("Lucifer Morningstar",   "Trust me, if there’s one thing I know, it’s desire"),
        new Entity("Roy Trenneman",   "People, what a bunch of bastards!"),
        new Entity("Joey",   "Joey doesn't share food!"),
        new Entity("Admiral Ackbar", "IT'S A TRAP!"),
        new Entity("Han Solo", "Never tell me the odds."),
        new Entity("Jack Torrance", "HEEEEEERE'S JOHNNY!"),
        new Entity("Pennywise", "Tasty, tasty, beautiful fear."),
        new Entity("Muldoon", "Clever girl."),
        new Entity("Honest_farmer", "It ain't much, but it's honest work."),
        new Entity("Cthulhu", "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn"),
        new Entity("Hades", "No, you cannot get out of here. Make yourself comfortable."),
        new Entity("Shady man", "Hey, you! Would you be interested into making some quick cash? You just have to be able to keep a secret."),
        new Entity("Northern mountain witch", "Sure, I can lift this curse. All I need is this list of ingredients. Can you get them for me?"),
        new Entity("Thief", "Hey, you are finally awake."),
        new Entity("Beggar", "Do you got some coin?"),
        new Entity("Kid", "I love going on cruises!"),
        new Entity("Teenager", "Shorts are very comfortable"),
        new Entity("Guard", "State your business or leave."),
        new Entity("Assassin", "You can close your eyes now. You won't ever have to open them again."),
        new Entity("Chuck", "Men are like steel. When they lose their temper, they lose their worth."),
        new Entity("Prophet", "It is during our darkest moments that we must focus to see the light."),
        new Entity("Ruth", "Never let the fear of striking out keep you from playing the game."),
        new Entity("Javik", "Stand in the ashes of a trillion dead souls, and asks the ghosts if honor matters. The silence is your answer."),
        new Entity("Richard", "Do you like hurting other people?"),
        new Entity("Guard", "I used to be an adventurer like you, then I took an arrow in the knee..."),
        new Entity("Rick", "Wubba lubba dub dub!"),
        new Entity("Morty", "Aw geez, Rick!"),
        new Entity("Strax", "Prepare to die, in agony, for the glory of the Sontaran empire!"),
        new Entity("Brick", "I love lamp..."),
        new Entity("Ron Swanson", "You've accidentally given me the food that my food eats."),
        new Entity("The Doctor", "Can you just hurry up please, or I'll hit you with my shoe."),
        new Entity("Bowl of petunias", "Oh no, not again..."),
        new Entity("Whiterun Guard", "I used to be an adventurer like you, then I took an arrow to the knee"),
        new Entity("Uncle Ben", "With great power comes great responsibility"),
        new Entity("Duke Nukem", "It's time to kick ass and chew bubble gum... and I'm all out of gum"),
        new Entity("Light Yagami", "I'll take a potato chip.... AND EAT IT"),
        new Entity("Walter White", "Say my name"),
        new Entity("Vaas", "Do you know the definition of insanity?"),
        new Entity("Robin Hood", "To rob the rich to pay the poor."),
        new Entity("Din Djarin", "This is the way."),
        new Entity("Ackbar", "It is a trap."),
        new Entity("Simon", "Are you Alliance?"),
        new Entity("Jayne", "Let's go be bad guys!"),
        new Entity("Marine","You want a piece of me, boy?"),
        new Entity("Battlecruiser","Yamato canon, online."),
        new Entity("50Cent", "Get rich or die trying"),
        new Entity("Frontend-Dev", "Lorem ipsum dolor sit amet"),
        new Entity("Walter Ulbricht", "Nobody has any intention of building a wall"),
        new Entity("Jim Lovell", "Houston we have a Problem"),
        new Entity("Harvey Specter", "When you are backed against the wall, break the goddamn thing down."),
        new Entity("Arnold Schwarzenegger", "GET TO THE CHOPPA!!"),
        new Entity("Captain IKEA", "Furniture, assemble!"),
        new Entity("The Black Knight", "It's just a flesh wound."),
        new Entity("Borat", "This is my wife."),
        new Entity("Borat", "Very nice!"),
        new Entity("L Lawliet", "If you use your head, you won't get fat even if you eat sweets."),
        new Entity("Miss Kobayashi", "Knowing you’re different is only the beginning. If you accept these differences you’ll be able to get past them and grow even closer."),
        new Entity("Fullmetal Alchemist", "How can you move forward when you keep regretting the past?"),
        new Entity("Hachiman Hikigaya", "Fake people have an image to maintain. Real people just don’t care."),
        new Entity("Sora", "Life is not a game of luck. If you wanna win, work hard."),
        new Entity("Mara Jade Skywalker", "It's not about the legacy you leave, it's about the life you live."),
        new Entity("Mara Jade Skywalker", "It is, as some admiral once said, a trap."),
        new Entity("Talon Karrde", "I've found that what most people call luck is often little more than raw talent combined with the ability to make the most of opportunities."),
        new Entity("Mako", "I'm not just a pretty side-kick buster!"),
        new Entity("K-2SO", "Jyn, I’ll be there for you. Cassian said I had to."),
        new Entity("Shmi Skywalker", "You can’t stop the change, any more than you can stop the suns from setting."),
        new Entity("Obi-Wan Kenobi", "Well, if droids could think, there’d be none of us here, would there?"),
        new Entity("Imperial Captain", "Forget the list. She goes to the block."),
        new Entity("Kayd", "I thought adventurers were supposed to look tough."),
        new Entity("Guard", "I got to thinking, maybe I'm the Dragonborn, and I just don't know it yet."),
        new Entity("Nelkir", "Another wanderer, here to lick my father's boots. Good job."),
        new Entity("Gimli", "BARUK KHAZAD")
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
