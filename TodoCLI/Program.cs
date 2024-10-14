using TodoCli.Entities;

Console.WriteLine("Start with commands or enter -h for help");

while (true)
{
  var userCommand = Console.ReadLine();
  UserCommandHandle(userCommand);
}

void UserCommandHandle(string command)
{
  var action = IdentifyAction(command);

  switch (action)
  {
    case "create":
      // CreateTodo(userInput[1]);
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


string IdentifyAction(string command)
=> command.Substring(0, command.IndexOf(' '));

