# NPC-Quotes
👾💭  A simple NPC quotes repo. You can contribute to Hacktoberfest easily.

## How to contribute to this project
Here are 4 quick and painless ways to contribute to this project:

* Fork this repository
* Clone the repository to your local machine
* Create new items following best practices 

Choose all 3, make a pull request for your work and wait for it to be merged!

## Getting started
* Fork this repository (Click the Fork button in the top right of this page, click your Profile Image)
* Clone your fork down to your local machine

```markdown
git clone https://github.com/your-username/NPC-Quotes.git
```

* Create a branch

```markdown
git checkout -b branch-name
```

* Make your changes (Perform all tasks above)
* Commit and push

```markdown
git add .
git commit -m 'Commit message'
git push origin branch-name
```

* Create a new pull request from your forked repository (Click the `New Pull Request` button located at the top of your repo)
* Wait for your PR review and merge approval!
* __Star this repository__ if you had fun!


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
