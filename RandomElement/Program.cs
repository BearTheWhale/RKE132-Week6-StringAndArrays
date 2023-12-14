//string[] snacks = { "Leb", "sai", "õlu", "burger", "pitsa" };

//Random rnd = new Random();

//int randomIndex = rnd.Next(0, snacks.Length);

//Console.WriteLine($"We are going to eat {snacks[randomIndex]}.");

string hello = "Hello, world!".Trim();
int spaceCounter = 0;

for (int i = 0; i < hello.Length; i++)

{

    if (char.IsWhiteSpace(hello[i]))
{ 
        spaceCounter++;

}

}

Console.WriteLine(spaceCounter + 1);