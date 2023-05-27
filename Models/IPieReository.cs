namespace eshop.Models
{
    public interface IPieReository
    {
        IEnumerable<Pie> ALLPies { get; }
        IEnumerable<Pie> PiesoftheWeek { get; }
        Pie? GetPiebyID(int pieId);
    }
}
