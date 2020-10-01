using System.Collections.Generic;
using System.Linq;

namespace NPC_Quotes
{
    public class NpcEntity
    {
        public string Name { get; set; }
        public List<string> Quotes { get; set; }

        public NpcEntity(){}
        public NpcEntity(string name, List<string> quotes)
        {
            Name = name;
            Quotes = quotes;
        }

        public NpcEntity(string name, IEnumerable<string> quotes)
        {
            Name = name;
            Quotes = quotes.ToList();
        }
    }
}