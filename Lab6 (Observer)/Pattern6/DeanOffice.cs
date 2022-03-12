using Pattern6.Interfaces;

namespace Pattern6;

public class DeanOffice : IObserver
{
    public Dictionary<string, bool> _reportStatuses = new();

    public void Update(object o)
    {
        string teacherID = o as string;
        _reportStatuses[teacherID] = true;
    }

    public string CheckReports()
    {
        int badProfessorsCount = 0;
        string report = "Professors that didn't fill reports:\n";
        foreach (var (teacherID, status) in _reportStatuses)
        {
            if (!status)
            {
                badProfessorsCount++;
                report += $"\t{teacherID}\n";
            }
        }

        return badProfessorsCount == 0 ? "All professors filled reports\n" : report;
    }

    public void NextWeek()
    {
        foreach (string teacherID in _reportStatuses.Keys)
        {
            _reportStatuses[teacherID] = false;
        }
    }
}