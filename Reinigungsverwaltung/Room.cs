namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Room
{
    private int _points;
    public int beds;
    public List<CleaningTask> cleaningTasks;
    public bool isSmoking;
    public int roomNumber;

    public Room(int roomnumber, int beds, bool smoking, int points)
    {
        roomNumber = roomnumber;
        this.beds = beds;
        isSmoking = smoking;
        Points = points;
    }

    public int Points
    {
        get => _points;
        set
        {
            if (value >= 0 && value <= 10) _points = value;
        }
    }

    public void AddCleaningTask(CleaningTask task)
    {
        cleaningTasks.Add(task);
    }
}