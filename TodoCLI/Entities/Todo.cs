using TodoCli.Enums;

namespace TodoCli.Entities;

public class Todo : BaseEntity
{
  public Todo(string title)
  {
    Title = title;
    Tasks = new List<Task>();
  }

  public string Title { get; private set; }
  public List<Task> Tasks { get; private set; } = new List<Task>();

  public void Add(string description)
  {
    var task = new Task(description);

    Tasks.Add(task);
  }

  public void Remove(int id)
  {
    var task = FindTaskById(id);
    Tasks.Remove(task);
  }

  public void UpdateDescription(int id, string description)
  {
    var task = FindTaskById(id);
    task.SetDescription(description);
  }

  public Task FindTaskById(int id)
    => Tasks.FirstOrDefault(t => t.Id == id);


  public void List()
  {
    foreach (var item in Tasks)
    {
      Console.WriteLine(item.Id);
      Console.WriteLine(item.Description);
      Console.WriteLine(item.StatusTask.ToString());
    }
  }

  public void ListTodo()
  {
    var tasksTodo = Tasks.Where(t => t.StatusTask == EStatusTask.Todo).ToList();

    foreach (var item in tasksTodo)
    {
      Console.WriteLine(item.Id);
      Console.WriteLine(item.Description);
      Console.WriteLine(item.StatusTask.ToString());
    }
  }
  public void ListInProgress()
  {
    var tasksTodo = Tasks.Where(t => t.StatusTask == EStatusTask.InProgress).ToList();

    foreach (var item in tasksTodo)
    {
      Console.WriteLine(item.Id);
      Console.WriteLine(item.Description);
      Console.WriteLine(item.StatusTask.ToString());
    }
  }
  public void ListDone()
  {
    var tasksTodo = Tasks.Where(t => t.StatusTask == EStatusTask.Done).ToList();

    foreach (var item in tasksTodo)
    {
      Console.WriteLine(item.Id);
      Console.WriteLine(item.Description);
      Console.WriteLine(item.StatusTask.ToString());
    }
  }
}