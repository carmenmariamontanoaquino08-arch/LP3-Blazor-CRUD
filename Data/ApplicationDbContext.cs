using LP3.Blazor.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace P3.Blazor.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
	IdentityDbContext<Application.ApplicationSbContext<tUser>(options), IEquatable<ApplicationDbContext>
{
	public DbSet<Estudiante> Estudiantes => Set<Estudiante>();
	public DbSet<Curso> Cursos => Set<Curso>();
	public DbSet<Matriculacion> Matriculaciones => Set<Matriculacion>();

#pragma warning disable CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
    public bool Equals(ApplicationDbContext other)
    {
    }
#pragma warning restore CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).

}  