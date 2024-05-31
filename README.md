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
