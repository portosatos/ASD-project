# todo list

# TaskManager Console Application


## Description

TaskManager is a simple console application that allows users to manage their tasks. The application provides functionality to add, remove, and manage tasks with the use of a custom data structure. This project is designed to demonstrate the use of custom data structures and effective collaboration using Git for version control.

## Features

- Add a new task
- Remove a task by ID
- Print all tasks
- Mark a task as completed
- Edit task description
- Clear all tasks
- Print only completed tasks
- Print only pending tasks

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or later)

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/TaskManager.git
    ```
2. Navigate to the project directory:
    ```bash
    cd TaskManager
    ```

### Running the Application

1. Build the project:
    ```bash
    dotnet build
    ```
2. Run the project:
    ```bash
    dotnet run
    ```

## Usage

The application is a console-based program. Once you run the application, it will execute a series of predefined operations as a demonstration. You can modify the `Main` method in `Program.cs` to test other functionalities.

## Methods

### AddTask
Adds a new task with a description.


```csharp
taskManager.AddTask("Task description");
```

### RemoveTask
Removes a task by its ID.

```csharp
taskManager.RemoveTask(1);
```



PrintAllTasks
Prints all tasks with their ID, description, and completion status.

```csharp
taskManager.PrintAllTasks();
```


MarkTaskAsCompleted
Marks a task as completed by its ID.

```csharp
taskManager.MarkTaskAsCompleted(1);
```



EditTaskDescription
Edits the description of a task by its ID.

```csharp
taskManager.EditTaskDescription(1, "New description");
```


ClearAllTasks
Clears all tasks from the list.

```csharp
taskManager.ClearAllTasks();
```



PrintCompletedTasks
Prints only the tasks that are marked as completed.

```csharp
taskManager.PrintCompletedTasks();
```


PrintPendingTasks
Prints only the tasks that are pending (not completed).


```csharp
taskManager.PrintPendingTasks();
```


Teamwork
This project was a collaborative effort. Below is a summary of contributions:

Nurlan: 
Aibike: 
Emir: I did not do the hardest part, which is to output completed tasks and also pending tasks. it was not hard because I looped through the tasks and just printed them. also I made a new class Program which is needed to see how our cloud sheet works.

Version control and collaboration were managed using Git. Regular commits, branching, and detailed commit messages were used to track progress and ensure smooth teamwork.





## Git Usage
- Branching: Feature branches were created for each method.
- Commit Messages: Detailed and meaningful commit messages were used for better tracking of changes.
- Pull Requests: Each feature was merged into the main branch via pull requests, ensuring code review and quality.
- License
This project is licensed under the MIT License. See the LICENSE file for details.




## Author`s of the project `Asankozhoev Nurlan` `Builasheva Aibike` `Dastanov Emir` 


