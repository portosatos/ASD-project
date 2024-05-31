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
}