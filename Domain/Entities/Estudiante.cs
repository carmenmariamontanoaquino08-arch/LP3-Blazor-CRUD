namespace LP3.Blazor.Domain.Entities;

public class Estudiante
{
    // ── Identificador único ───────────────────────────────
    public int Id { get; set; }

    // ── Datos del estudiante ──────────────────────────────
    public string Nombre         { get; set; } = string.Empty;
    public string Apellido       { get; set; } = string.Empty;
    public string Matricula      { get; set; } = string.Empty;
    public string Email          { get; set; } = string.Empty;
    public DateTime FechaIngreso { get; set; }
                
  }