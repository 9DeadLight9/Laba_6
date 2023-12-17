using Tusk_4;

class Program
{
    static void Main()
    {
        var scheduler = new TaskScheduler<string, int>();

        
        scheduler.AddTask("Task1", 1);
        scheduler.AddTask("Task2", 2);
        scheduler.AddTask("Task3", 3);

    
        TaskExecution<string> execution = task => Console.WriteLine($"Executing {task}");

     
        scheduler.ExecuteNext(execution);
        scheduler.ExecuteNext(execution);
        scheduler.ExecuteNext(execution);
    }
}
