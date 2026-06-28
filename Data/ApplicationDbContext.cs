





namespace P3.Blazor.Data;

public class ApplicationDbContext
{
    public ApplicationDbContext()
    {
    }

    public object Cursos { get; internal set; }

    internal async Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}