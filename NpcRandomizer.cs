using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace NPC_Quotes
{
    public class NpcRandomizer
    {
        private Random _random;
        private List<NpcEntity> _entities;
        private int _entityCount;
        
        private static readonly NpcRandomizer _instance = new NpcRandomizer();
        public static NpcRandomizer Instance => _instance;
        
        private const string NpcNodeAlias = "Entity";
        private const string NpcNodeNameAlias = "name";
        private const string QuoteNodeAlias = "Quote";
        private const string QuoteNodeTextAlias = "text";
        
        static NpcRandomizer()
        {
            // A static constructor is used.
            // It is called automatically before the first instance is created or any static members are referenced.
        }
        
        /// <summary>
        /// Class with API to return random entities
        /// </summary>
        private NpcRandomizer()
        {
            _random = new Random();
            _entities = GetEntitiesFromXml("Entities.xml");
            _entityCount = _entities.Count;
        }

        private List<NpcEntity> GetEntitiesFromXml(string filePath)
        {
            return XElement.Load(filePath)
                .Elements(NpcNodeAlias)
                .Select(level1Element => new NpcEntity
                {
                    Name = level1Element.Attribute(NpcNodeNameAlias)?.Value ?? string.Empty,
                    Quotes = level1Element.Elements(QuoteNodeAlias)
                        .Select(level2Element => level2Element.Attribute(QuoteNodeTextAlias)?.Value ?? string.Empty)
                        .Where(quote => !string.IsNullOrEmpty(quote))
                        .ToList()
                })
                .Where(entity => !string.IsNullOrEmpty(entity.Name) && entity.Quotes.Any())
                .ToList();
        }

        private int GetRandomNumber(int max) => _random.Next(0, max + 1);
        private int GetRandomEntity() => GetRandomNumber(_entityCount);

        /// <summary>
        /// Return a random Npc instance
        /// </summary>
        /// <returns>NpcEntity</returns>
        public NpcEntity GetRandomNpc()
        {
            return _entities[GetRandomEntity()];
        }
        
        /// <summary>
        /// Returns a random Npc name
        /// </summary>
        /// <returns>string</returns>
        public string GetRandomNpcName()
        {
            NpcEntity npc = GetRandomNpc();
            return npc.Name;
        }
        
        /// <summary>
        /// Returns a random Npc quote
        /// </summary>
        /// <returns>string</returns>
        public string GetRandomNpcQuote()
        {
            NpcEntity npc = GetRandomNpc();
            return npc.Quotes[GetRandomNumber(npc.Quotes.Count)];
        }
        
        /// <summary>
        /// Returns a NpcEnity by name
        /// </summary>
        /// <returns>NpcEntity or null</returns>
        public NpcEntity GetNpcByName(string name, StringComparison comparison = StringComparison.Ordinal)
        {
            return _entities.Find(e => string.Equals(e.Name, name, comparison));
        }
    }
}