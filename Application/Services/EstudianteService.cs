using LP3.Blazor.Data.Repositories;
using LP3.Blazor.Domain.Entities;
using LP3.Blazor.Shared.DTOs;
using LP3.Blazor.Shared.Extensions;

namespace LP3.Blazor.Application.Services;

public class EstudianteService(IEstudianteRepository estudianteRepository) : IEstudianteService
{
    public async Task<ICollection<EstudianteDto>> GetAll()
    {
        var estudiantes = await estudianteRepository.ListAsync();
        return estudiantes.Select(e => e.ToDto()).ToList();
    }

    public async Task<EstudianteDto?> GetByIdAsync(int id)
    {
        var estudiante = await estudianteRepository.GetByIdAsync(id);
        return estudiante?.ToDto();
    }

    public async Task<EstudianteDto?> GetByMatriculaAsync(string matricula)
    {
        var estudiante = await estudianteRepository.GetByMatriculaAsync(matricula);
        return estudiante?.ToDto();
    }

    public async Task<bool> CreateAsync(EstudianteDto dto)
    {
        try
        {
            var estudiante = new Estudiante
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Matricula = dto.Matricula,
                //Email = dto.Email,
                FechaIngreso = DateTime.UtcNow,
                Estado = Domain.Enums.EstadoEstudiante.Activo
            };

            await estudianteRepository.AddAsync(estudiante);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> UpdateAsync(int id, EstudianteDto dto)
    {
        try
        {
            var estudiante = await estudianteRepository.GetByIdAsync(id);
            if (estudiante == null) return false;

            estudiante.Nombre = dto.Nombre;
            estudiante.Apellido = dto.Apellido;
            //estudiante.Email = dto.Email;
            estudiante.ActualizadoEn = DateTime.UtcNow;

            await estudianteRepository.Update(estudiante);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteAsync(int id)
    {
        try
        {
            var estudiante = await estudianteRepository.GetByIdAsync(id);
            if (estudiante == null) return false;

            await estudianteRepository.Remove(estudiante);
            return true;
        }
        catch
        {
            return false;
        }
    }
}