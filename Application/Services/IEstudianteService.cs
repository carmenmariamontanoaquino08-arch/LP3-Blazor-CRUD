using LP3.Blazor.Shared.DTOs;

namespace LP3.Blazor.Application.Services;

public interface IEstudianteService
{
    Task<ICollection<EstudianteDto>> GetAll();
    Task<EstudianteDto?> GetByIdAsync(int id);
    Task<EstudianteDto?> GetByMatriculaAsync(string matricula);
    Task<bool> CreateAsync(EstudianteDto dto);
    Task<bool> UpdateAsync(int id, EstudianteDto dto);
    Task<bool> DeleteAsync(int id);
}