# NPC-Quotes
👾 💭 A simple NPC quotes repo 💡


Random npcs can be queried using the `NpcRandomizer` class. This class is a singleton and can be, the instance can be obtained using the static `Instance` property.

### Methods

There are a number of methods that are exposed in the `NpcRandomizer` class. Which are:

* `GetRandomNpc`: returns a random `NpcEntity` instance
* `GetRandomNpcName`: returns a random name as string
* `GetRandomNpcQuote`: returns a random quote as name
* `GetNpcByName`: searches for a Npc by name parameter, additional StringComparison mode can be supplied


#### Example
``` csharp
    NpcEntity npc = NpcRandomizer.Instance.GetRandomNpc();
    Debug.Log($"{npc.Name} says {npc.Quotes[0]}");
```

#### Result:

```
    Ned says Winter is coming...
```