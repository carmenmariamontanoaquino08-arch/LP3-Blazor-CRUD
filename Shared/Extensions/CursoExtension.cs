using LP3.Blazor.Domain.Entities;
using LP3.Blazor.Shared.DTOs;

namespace MLP3.Blazor.Shared.Extensions;

public static class CursoExtensions
{
    public static CursoDto ToDto(this Curso curso)
    {
        return new CursoDto 
        {
            Id = curso.Id,
            Nombre = curso.Nombre,
            Codigo = curso.Codigo,
            Creditos = curso.Creditos,
            Activo = curso.Activo
        };
    }
}