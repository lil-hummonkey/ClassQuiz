
string action;

Tamagotchi knob = new Tamagotchi();

List<Opponent> opponents = new() {new("Albert"), new("Herbert"), new("Tina")};

knob.Fight(opponents[0]);

Console.WriteLine("what will you call your tamagotchi?");

knob.name = Console.ReadLine();


Console.WriteLine($"{knob.name}");
while(knob.getAlive() == true)
{

Console.Clear();
knob.printStats();

Console.WriteLine("Do you want to:");
Console.WriteLine("1. Feed?");
Console.WriteLine("2. Teach? ");
Console.WriteLine("3. Talk?");
Console.WriteLine("4. Fight");
Console.WriteLine("5. Do nothing");

action = Console.ReadLine();

if(action == "1" || action == "Feed")
{
    knob.Feed();
    
}

if(action == "2" || action == "Teach")
{
    Console.WriteLine("what word?");
    string word = Console.ReadLine();
    knob.Teach(word);
    
}

if(action == "3" || action == "Talk")
{
    knob.Greet();
    
}

if(action == "4" || action == "Fight")
{
    //if (opponent.health > 0)
    //what attack?
    //write all attacks you can do
    //console readline
    //pick the number written
    //run the math on attack
    //check if he died
    
    knob.Fight();
    
}

else
{
    Console.WriteLine("You did nothing");
    

}

knob.Tick();
Console.ReadLine();

}

Console.WriteLine($"{knob.name} had a stroke and died");
Console.ReadLine();