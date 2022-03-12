using Pattern6.Interfaces;

namespace Pattern6;

public class Teacher : IObservable
{
    private string TeacherID;
    private List<IObserver> _observers;

    public Teacher(string teacherID)
    {
        TeacherID = teacherID;
        _observers = new List<IObserver>();
    }

    public void AddObserver(IObserver obs)
    {
        _observers.Add(obs);
    }

    public void RemoveObserver(IObserver obs)
    {
        _observers.Remove(obs);
        (obs as DeanOffice)._reportStatuses.Remove(TeacherID);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(TeacherID);
        }
    }
}