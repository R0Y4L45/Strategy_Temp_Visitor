
public abstract class Game
{
    abstract public void Initialize();
    abstract public void StartPlay();
    abstract public void EndPlay();

    //template method
    public void play()
    {

        //initialize the game
        Initialize();

        //start game
        StartPlay();

        //end game
        EndPlay();
    }
}


public class Cricket : Game
{

    public override void EndPlay()
    {
        Console.WriteLine("Cricket Game Finished!");
    }


    public override void Initialize()
    {
        Console.WriteLine("Cricket Game Initialized! Start playing.");
    }


    public override void StartPlay()
    {
        Console.WriteLine("Cricket Game Started. Enjoy the game!");
    }
}


public class Football : Game
{

   public override void EndPlay()
    {
        Console.WriteLine("Football Game Finished!");
    }

    public override void Initialize() 
    {
        Console.WriteLine("Football Game Initialized! Start playing.");
    }

    public override void StartPlay() 
    {
        Console.WriteLine("Football Game Started. Enjoy the game!");
    }
}


public class TemplatePatternDemo
{
    public static void Main()
    {

        Game game = new Cricket();
        game.play();
        Console.WriteLine();
        game = new Football();
        game.play();
    }
}