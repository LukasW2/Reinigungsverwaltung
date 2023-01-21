namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public abstract class CleaningTask
{
    protected List<CleaningTask> _cleaningTasks = new();
    public List<Products> Products = new List<Products>();
    public Zeitstempel zeitstempel { get; set; }

    protected CleaningTask(string taskId, string description, string status, int points, Products products)
    {
        this.taskId = taskId;
        this.description = description;
        this.status = status;
        this.points = points;
        Products.Add(products);
    }

    public string taskId { get; set; }
    public string description { get; set; }
    public string status { get; set; }
    public int points { get; set; }
    public virtual List<CleaningTask> CleaningTasks => _cleaningTasks;

    public void AddCleaningTask(CleaningTask task)
    {
        _cleaningTasks.Add(task);
    }

    public void RemoveCleaningTask(CleaningTask task)
    {
        _cleaningTasks.Remove(task);
    }

    public int CleaningTasksQuantity()
    {
        return _cleaningTasks.Count;
    }
}