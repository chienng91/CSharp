namespace CSharpp;

public interface IPlayable
{
    void Play();
    int Duration { get; } // minutes
}
public interface IReminder
{
    string Reminder();
}

public abstract class Entertaiment : IPlayable
{
    public string Title {get; set;}
    public int Duration {get; protected set;}

    protected Entertaiment(string title, int duration)
    {
        Title = title;
        Duration = duration;
    }
    public abstract void Play();
}
public class PlayAMusic : Entertaiment
{
    public string Singer {get; set;}
    public PlayAMusic(string title, string singer, int duration)
        : base(title, duration)
    {
        Singer = singer;
    }
    public override void Play()
    {
        Console.WriteLine($"Playing  {Title} by {Singer}\n DurationL: {Duration} minutes");
    }
}
public class PlayAMovie : Entertaiment
{
    public string Director {get; set;}

    public PlayAMovie(string title, string director, int duration)
        : base(title, duration)
    {
        Director = director;
    }
    public override void Play()
    {
        Console.WriteLine($"Watching {Title} by {Director} \n Duration: {Duration} minutes");
    }
}
public class PlayAVideoGame : Entertaiment, IReminder
{
    public string Genre {get; set;}
    public int NumberOfPlayers {get; set;}
    public PlayAVideoGame(string title, string genre, int numberOfPlayers, int duration)
        :base(title, duration)
    {
        Genre = genre;
        NumberOfPlayers = numberOfPlayers;
    }
    public override void Play()
    {
        Console.WriteLine($"Playing game {Title} \n Genre: {Genre} \n Duration: {Duration} minutes \n Max Players: {NumberOfPlayers}");
    }
    
    public string Reminder()
    {
        return $"Chuc ban choi game vui ve. Hay nho nghi ngoi neu cam thay met";
    }
}
public static class RunIPlayable
{
    public static void Run()
    {
        List<IPlayable> listPlayable = new()
        {
            new PlayAMusic("Shape of you", "Ed Sheeran", 4),
            new PlayAMovie("Tho oi", "Tran Thanh", 125),
            new PlayAVideoGame("Valorant", "FPS", 5, 120),
        };
        int totalDuration = 0;

        foreach (IPlayable playable in listPlayable)
        {   
            Console.WriteLine(playable);
            playable.Play();
            if (playable is IReminder reminder)
            {
                Console.WriteLine(reminder.Reminder());
            }
            totalDuration += playable.Duration;
        }
        Console.WriteLine($"Total activity time in a day: {totalDuration} minutes");

    }
}