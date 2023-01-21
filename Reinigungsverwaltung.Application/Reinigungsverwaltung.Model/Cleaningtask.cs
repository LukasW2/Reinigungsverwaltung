namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public abstract class CleaningTask
{
    public string taskId{ get; set; }
    public string description{ get; set; }
    public string status{ get; set; }
    public int points { get; set; }
    private Products products;
    private List<CleaningTask> cleaningTasks;

    protected CleaningTask(string taskId, string description, string status, int points, Products products)
    {
        this.taskId = taskId;
        this.description = description;
        this.status = status;
        this.points = points;
        this.products = products;
    }

    public void AddCleaningTask(CleaningTask task)
    {
        cleaningTasks.Add(task);
    }
    
    public void RemoveCleaningTask(CleaningTask task)
    {
        cleaningTasks.Remove(task);
    }
    
    
    
}
