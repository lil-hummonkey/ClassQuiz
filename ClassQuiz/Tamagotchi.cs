public class Tamagotchi 
{
    int hunger = 0;
    int boredom = 0;

    int power = 10;
    int health = 40;

   

    private Random generator = new();
    public bool isAlive = true;
    private List<string> words = new List<string>() {"cum"};
    public string name;
    

    public Tamagotchi()
    {
        isAlive = true;
    }

    public void printStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: || {hunger} || Boredom: {boredom} || Words: {words.Count}");
    }
    public void Tick()
    {
        boredom++;
        hunger++;

        if (hunger >= 10 || boredom >= 10)
        {
            isAlive = false;
        }
    }
    public bool getAlive()
    {
        return isAlive;
    }

    public void Greet()
    {
    int wordNum = generator.Next(words.Count);
    Console.WriteLine($"[{name}] says {words[wordNum]}");  
    Boredom(); 
    }
    public void Feed()
    {   
        hunger -= 2; 
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void Boredom()
    {
        boredom -= 3;


        if (boredom < 0)
        {
            boredom = 0;
        }
    }
     public void Teach(string word)
    {
        Console.WriteLine($" [{name}] learns: {word}");
        words.Add(word);
        Boredom();
        
    }

    public void Fight(Opponent opp1)
    {
        
        
        Console.WriteLine($"You will fight against {opp1.name}");
        while(opp1.health > 0)
        {
            Console.WriteLine($"{opp1.name} has {opp1.health}");
            Console.ReadLine();
            Console.WriteLine("What will you do?");
            Console.WriteLine("1. Attack?");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
            opp1.health -= power;
            }
            else
            {
            Console.WriteLine("You did nothing");    
            }
            Console.WriteLine($"{opp1.name} has {opp1.health}");
            Console.ReadLine();
            health -= opp1.power;

        }
    }
   
}