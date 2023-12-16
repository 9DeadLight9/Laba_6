namespace Tusk_3;
using System;
using System.Collections.Generic;

public delegate void TaskExecution<TTask>(TTask task);

public class TaskScheduler<TTask, TPriority> where TPriority : IComparable<TPriority>
{
    private readonly SortedDictionary<TPriority, Queue<TTask>> tasks = new SortedDictionary<TPriority, Queue<TTask>>();

    public void AddTask(TTask task, TPriority priority)
    {
        if (!tasks.ContainsKey(priority))
        {
            tasks[priority] = new Queue<TTask>();
        }

        tasks[priority].Enqueue(task);
    }

    public void ExecuteNext(TaskExecution<TTask> execution)
    {
        if (tasks.Count == 0)
        {
            throw new InvalidOperationException("No tasks available");
        }

        var highestPriority = GetHighestPriority();
        var task = tasks[highestPriority].Dequeue();

        if (tasks[highestPriority].Count == 0)
        {
            tasks.Remove(highestPriority);
        }

        execution(task);
    }

    private TPriority GetHighestPriority()
    {
        TPriority highestPriority = default(TPriority);

        foreach (var priority in tasks.Keys)
        {
            if (highestPriority == null || priority.CompareTo(highestPriority) > 0)
            {
                highestPriority = priority;
            }
        }

        return highestPriority;
    }
}