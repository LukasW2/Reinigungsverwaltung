namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Employee
{
    private int EmployeeId { get; set; }
    private string Name{ get; set; }
    private string Position{ get; set; }
    
    private List<CleaningTask> _activeTasks;

    public Employee(int employeeid, string name, string position)
{
        this.EmployeeId = employeeid;
        this.Name = name;
        this.Position = position;
        this._activeTasks = new List<CleaningTask>();
    }
    
    List<Employee> _employees = new List<Employee>();
    
    
#pragma warning disable CS8618
    protected Employee(string position)
    {
        Position = position;
    }
#pragma warning restore CS8618
    
    public List<CleaningTask> ActiveTasks
    {
        get { return _activeTasks; }
        set { _activeTasks = value; }
    }

    public List<CleaningTask> GetActiveTasks()
    {
        return _activeTasks;
    }
    
    public void AddEmployee(int employeeId, string name, string position)
    {
        Employee newEmployee = new Employee(employeeId, name, position);
        _employees.Add(newEmployee);
    }

    public void RemoveEmployee(Employee emp)
    {
        _employees.Remove(emp);
    }
    
}