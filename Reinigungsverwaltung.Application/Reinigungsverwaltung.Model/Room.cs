namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Room
{
    private int roomNumber;
    private int beds;
    private bool isSmoking;
    private List<CleaningTask> cleaningTasks;

    public Room()
    {
        cleaningTasks = new List<CleaningTask>();
    }

    public void AddCleaningTask(CleaningTask task)
    {
        cleaningTasks.Add(task);
    }
    
    
}