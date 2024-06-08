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
               var task = tasks.Pop();
            if (task.Description == oldDescription)
            {
                task.Description = newDescription;
            }
            tempStack.Push(task);
        }

        while (tempStack.Count > 0)
        {
            tasks.Push(tempStack.Pop());
        }
    }

    public void ClearAllTasks()
    {
        tasks.Clear();
    } public void MarkTaskAsCompleted(string description)
    {
        var tempStack = new Stack<Task>();

        while (tasks.Count > 0)
        {
            var task = tasks.Pop();
            if (task.Description == description)
            {
                task.IsCompleted = true;
            }
            tempStack.Push(task);
        }

        while (tempStack.Count > 0)
        {
            tasks.Push(tempStack.Pop());
        }
    }

    public void EditTaskDescription(string oldDescription, string newDescription)
    {
        var tempStack = new Stack<Task>();

        while (tasks.Count > 0)
        {


Nurik

    public void PrintCompletedTasks()
    {
        Console.WriteLine("Completed Tasks:");
        var tempStack = new Stack<Task>(tasks);

        foreach (var task in tempStack)
        {
            if (task.IsCompleted)
            {
                Console.WriteLine(task);
            }
        }
    }

    public void PrintPendingTasks()
    {
        Console.WriteLine("Pending Tasks:");
        var tempStack = new Stack<Task>(tasks);

        foreach (var task in tempStack)
        {
            if (!task.IsCompleted)
            {
                Console.WriteLine(task);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ToDoList toDoList = new ToDoList();

        toDoList.AddTask("Research ARW");
        toDoList.AddTask("ML lab work");
        toDoList.AddTask("Team Contract PM");

        toDoList.PrintAllTasks();

        toDoList.MarkTaskAsCompleted("ML lab work");

        toDoList.PrintCompletedTasks();
        toDoList.PrintPendingTasks();

        toDoList.EditTaskDescription("Team Contract PM", "Team Contract PM - Updated");

        toDoList.PrintAllTasks();

        toDoList.RemoveTask("Research ARW");

        toDoList.PrintAllTasks();

        toDoList.ClearAllTasks();
        toDoList.PrintAllTasks();
    }
}
