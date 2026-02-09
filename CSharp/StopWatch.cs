namespace CSharpp;

public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;
    public StopWatch()
    {
        startTime = DateTime.Now;
    }
    public DateTime StartTime
    {
        get { return startTime; }
    }
    public DateTime EndTime
    {
        get { return endTime; } 
    }
    public void Start()
    {
        startTime = DateTime.Now;
    }
    public void Stop()
    {
        endTime = DateTime.Now;
    }
    public double GetElapsedTime()
    {
         return (endTime - startTime).TotalMilliseconds;
    }
}

class StopWatch2
{
    public static void Run()
    {
        StopWatch stopWatch = new StopWatch();
        stopWatch.Start();
        stopWatch.Stop();
        Console.WriteLine("Thoi gian troi qua " + stopWatch.GetElapsedTime() +"ms");
    }
}
class StopWatch3
{
    public static void Run()
    {
        int size = 100000;
        int[] arr = new int[size];
        Random rd = new Random(); //Random so
        for (int i = 0; i < size; i++)
        {
            arr[i] = rd.Next(0,1000000); //Random so trong khoang 0-1000000
        }
        
        StopWatch stopWatch = new StopWatch();
        stopWatch.Start();
        SortArr(arr);
        stopWatch.Stop();
        Console.WriteLine("Thoi gian troi qua " + stopWatch.GetElapsedTime() +"ms");

        return;
        static void SortArr(int[] arr)
        {
            int n = arr.Length;
            for (int j = 0; j < n; j++)
            {
                int minIndex = j;
                for (int x = j + 1; x < n; x++) 
                {
                    if (arr[x] < arr[minIndex])   //so sanh 2 so o index minIndex va x
                    {
                        minIndex = x;
                    }
                }
                int temp = arr[minIndex]; // Doi vi tri 2 o
                arr[minIndex] = arr[j];
                arr[j] = temp;
            }
        }
    }
}