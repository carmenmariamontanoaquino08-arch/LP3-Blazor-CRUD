using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LP3.Blazor.Domain.Entities;

namespace LP3.Blazor.Application.Data;

public class ApplicationDbContext
    : IdentityDbContext<ApplicationContext>, IEquatable<ApplicationDbContext>
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Estudiante> Estudiantes => Set<Estudiante>();

    public DbSet<Curso> Cursos => Set<Curso>();

    public DbSet<Matriculacion> Matriculaciones => Set<Matriculacion>();

    public bool Equals(ApplicationDbContext other)
    {
        throw new NotImplementedException();
    }
}

public class ApplicationContext
{
}