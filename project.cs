using System;
using System.Collections.Generic;
using System.Linq;

class Task
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string description)
    {
        Description = description;
        IsCompleted = false;
    }
    public override string ToString()
    {
        return $"{Description} (Completed: {IsCompleted})";
    }
}

class ToDoList
{
    private Stack<Task> tasks;

    public ToDoList()
    {
        tasks = new Stack<Task>();
    }

    public void AddTask(string description)
    {
        tasks.Push(new Task(description));
    }

    public void RemoveTask(string description)
    {
        var tempStack = new Stack<Task>();
        bool removed = false;

        while (tasks.Count > 0)
        {
            var task = tasks.Pop();
            if (!removed && task.Description == description)
            {
                removed = true;
            }
            else
            {
                tempStack.Push(task);
            }
        }

        while (tempStack.Count > 0)
        {
            tasks.Push(tempStack.Pop());
        }
    }

    public void PrintAllTasks()
    {
        Console.WriteLine("All Tasks:");
        var tempStack = new Stack<Task>(tasks);

        foreach (var task in tempStack)
        {
            Console.WriteLine(task);
        }
    }
