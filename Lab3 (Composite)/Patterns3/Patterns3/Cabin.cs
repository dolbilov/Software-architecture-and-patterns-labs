namespace Patterns3;

public class Cabin : PlanePart
{
    public List<PlanePart> Parts;

    public Cabin()
    {
        Parts = new List<PlanePart>();
    }
    public Cabin(IEnumerable<PlanePart> parts)
    {
        Parts = parts.ToList();
    }
    public override float SummaryWeight()
    {
        return Parts.Sum(p => p.SummaryWeight());
    }
}