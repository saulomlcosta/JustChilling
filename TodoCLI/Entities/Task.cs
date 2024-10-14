using TodoCli.Enums;

namespace TodoCli.Entities;

public class Task : BaseEntity
{
  public Task(string description)
  {
    Description = description;
    StatusTask = EStatusTask.Todo;
    CreatedAt = DateTime.Now;
  }

  public string Description { get; private set; } = string.Empty;
  public EStatusTask StatusTask { get; private set; }
  public DateTime CreatedAt { get; private set; }
  public DateTime UpdatedAt { get; private set; }

  public void SetDescription(string description)
  {
    Description = description ?? string.Empty;
    UpdatedAt = DateTime.Now;
  }

  public void SetStatusInProgress()
  {
    StatusTask = EStatusTask.InProgress;
    UpdatedAt = DateTime.Now;
  }

  public void SetStatusDone()
  {
    StatusTask = EStatusTask.Done;
    UpdatedAt = DateTime.Now;
  }
}