<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>TaskManager Console Application</title>
</head>
<body>
    <h1>TaskManager Console Application</h1>

    <h2>Description</h2>
    <p>TaskManager is a simple console application that allows users to manage their tasks. The application provides functionality to add, remove, and manage tasks with the use of a custom data structure. This project is designed to demonstrate the use of custom data structures and effective collaboration using Git for version control.</p>

    <h2>Features</h2>
    <ul>
        <li>Add a new task</li>
        <li>Remove a task by ID</li>
        <li>Print all tasks</li>
        <li>Mark a task as completed</li>
        <li>Edit task description</li>
        <li>Clear all tasks</li>
        <li>Print only completed tasks</li>
        <li>Print only pending tasks</li>
    </ul>

    <h2>Getting Started</h2>

    <h3>Prerequisites</h3>
    <p>.NET SDK (version 5.0 or later)</p>

    <h3>Installation</h3>
    <ol>
        <li>Clone the repository:</li>
        <pre><code>git clone https://github.com/yourusername/TaskManager.git</code></pre>
        <li>Navigate to the project directory:</li>
        <pre><code>cd TaskManager</code></pre>
    </ol>

    <h3>Running the Application</h3>
    <ol>
        <li>Build the project:</li>
        <pre><code>dotnet build</code></pre>
        <li>Run the project:</li>
        <pre><code>dotnet run</code></pre>
    </ol>

    <h2>Usage</h2>
    <p>The application is a console-based program. Once you run the application, it will execute a series of predefined operations as a demonstration. You can modify the <code>Main</code> method in <code>Program.cs</code> to test other functionalities.</p>

    <h2>Methods</h2>

    <h3>AddTask</h3>
    <p>Adds a new task with a description.</p>
    <pre><code>taskManager.AddTask("Task description");</code></pre>

    <h3>RemoveTask</h3>
    <p>Removes a task by its ID.</p>
    <pre><code>taskManager.RemoveTask(1);</code></pre>

    <h3>PrintAllTasks</h3>
    <p>Prints all tasks with their ID, description, and completion status.</p>
    <pre><code>taskManager.PrintAllTasks();</code></pre>

    <h3>MarkTaskAsCompleted</h3>
    <p>Marks a task as completed by its ID.</p>
    <pre><code>taskManager.MarkTaskAsCompleted(1);</code></pre>

    <h3>EditTaskDescription</h3>
    <p>Edits the description of a task by its ID.</p>
    <pre><code>taskManager.EditTaskDescription(1, "New description");</code></pre>

    <h3>ClearAllTasks</h3>
    <p>Clears all tasks from the list.</p>
    <pre><code>taskManager.ClearAllTasks();</code></pre>

    <h3>PrintCompletedTasks</h3>
    <p>Prints only the tasks that are marked as completed.</p>
    <pre><code>taskManager.PrintCompletedTasks();</code></pre>

    <h3>PrintPendingTasks</h3>
    <p>Prints only the tasks that are pending (not completed).</p>
    <pre><code>taskManager.PrintPendingTasks();</code></pre>

    <h2>Teamwork</h2>
    <p>This project was a collaborative effort. Below is a summary of contributions:</p>
    <ul>
        <li><strong>Alice</strong>: Implemented the <code>AddTask</code>, <code>RemoveTask</code>, and <code>PrintAllTasks</code> methods. Set up the initial project structure.</li>
        <li><strong>Bob</strong>: Implemented the <code>MarkTaskAsCompleted</code>, <code>EditTaskDescription</code>, and <code>ClearAllTasks</code> methods. Contributed to debugging and optimization.</li>
        <li><strong>Charlie</strong>: Implemented the <code>PrintCompletedTasks</code> and <code>PrintPendingTasks</code> methods. Improved the user interface and documentation.</li>
    </ul>
    <p>Version control and collaboration were managed using Git. Regular commits, branching, and detailed commit messages were used to track progress and ensure smooth teamwork.</p>

    <h2>Git Usage</h2>
    <ul>
        <li><strong>Branching</strong>: Feature branches were created for each method.</li>
        <li><strong>Commit Messages</strong>: Detailed and meaningful commit messages were used for better tracking of changes.</li>
        <li><strong>Pull Requests</strong>: Each feature was merged into the main branch via pull requests, ensuring code review and quality.</li>
    </ul>

    <h2>License</h2>
    <p>This project is licensed under the MIT License. See the <a href="LICENSE">LICENSE</a> file for details.</p>

    <h2>Acknowledgments</h2>
    <p>Project inspired by common task management needs.</p>
    <p>Special thanks to the team members for their dedication and collaboration.</p>
</body>
</html>


