# NPC-Quotes
👾💭  A simple NPC quotes repo. You can contribute to Hacktoberfest easily.

### Unity sample

``` csharp
void Start()
{
    var npc = NPC.GetRandom();
    Debug.Log(npc.name + " says: "+ npc.quote);
}
```

Result:

```
    Ned says: Winter is coming...
```

### Any .NET platform sample

``` csharp
    var npc = NPC.GetRandom();
    Console.WriteLine(npc.name + " says: "+ npc.quote);
```

Result:

```
    Ned says: Winter is coming...
```
