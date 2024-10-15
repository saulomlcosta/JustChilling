using TodoCli.Entities;

List<Todo> todoLists = new List<Todo>();

Console.WriteLine("Please enter a command or -h to list available commands");

while (true)
{
  var userInput = Console.ReadLine();
  UserInputHandler(userInput);
}

void UserInputHandler(string input)
{
  var inputParsed = input.ParseInput();

  switch (inputParsed.action)
  {
    case "-h":
      ListCommands();
      break;
    case "list":
      ListTodos();
      break;
    case "create":
      CreateTodo(inputParsed.title!);
      break;
    case "add":
      break;
    case "update":
      break;
    default:
      Console.WriteLine("Command not recognized.");
      break;
  }
}

void ListCommands()
{
  Console.WriteLine("Commands");
  Console.WriteLine("  list                             List all todos");
  Console.WriteLine("  create                           Create a new Todo");

  Console.WriteLine("Usage");
  Console.WriteLine("  list");
  Console.WriteLine("  create \"example\"");
}


void ListTodos()
{
  foreach (var todo in todoLists)
  {
    Console.WriteLine($"{todo.Id} - {todo.Title}");
  }
}

void CreateTodo(string title)
{
  var todo = new Todo(title);
  todoLists.Add(todo);
  Console.WriteLine($"Todo {title} was created successfully!");
}

