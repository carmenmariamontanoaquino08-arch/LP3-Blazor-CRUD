using LP3.Blazor.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace P3.Blazor.Data;

public interface ApplicationDbContext
{
    DbSet<Estudiante> Estudiantes { get; }
    DbSet<Curso> Cursos { get; }
    DbSet<Matriculacion> Matriculaciones { get; }

    bool Equals(ApplicationDbContext other);
}
