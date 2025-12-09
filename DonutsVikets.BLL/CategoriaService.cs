// Project.BLL/Services/CategoriaService.cs
using DonutsVikets.DAL.Repositories;
using DonutsVikets.DTOs;
using DonutsVikets.Models;

namespace Project.BLL.Services
{
    // Serviço de negócio que usa CategoriaRepository diretamente (sem interface).
    public class CategoriaService
    {
        private readonly CategoriaRepository _repo;

        public CategoriaService(CategoriaRepository repo)
        {
            _repo = repo;
        }

        public CategoriaService()
        {
        }

        public async Task<IEnumerable<CategoriaDTO>> GetAllAsync()
        {
            var list = await _repo.GetAllAsync();
            var dto = new List<CategoriaDTO>();
            foreach (var c in list)
            {
                dto.Add(EntityToDto(c));
            }
            return dto;
        }

        public async Task<CategoriaDTO?> GetByIdAsync(int id)
        {
            var c = await _repo.GetByIdAsync(id);
            return c == null ? null : EntityToDto(c);
        }

        public async Task<(bool success, string message)> CreateAsync(CategoriaDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Nome))
                return (false, "Nome da categoria é obrigatório.");

            var existing = await _repo.GetByNomeAsync(dto.Nome);
            if (existing != null)
                return (false, "Já existe uma categoria com esse nome.");

            var categoria = new Categoria
            {
                Nome = dto.Nome,
                Descricao = dto.Descricao
            };

            await _repo.AddAsync(categoria);
            return (true, "Categoria criada com sucesso.");
        }

        public async Task<(bool success, string message)> UpdateAsync(CategoriaDTO dto)
        {
            if (!await _repo.ExistsAsync(dto.Id))
                return (false, "Categoria não encontrada.");

            var c = await _repo.GetByIdAsync(dto.Id);
            if (c == null)
                return (false, "Categoria não encontrada.");

            c.Nome = dto.Nome;
            c.Descricao = dto.Descricao;

            await _repo.UpdateAsync(c);
            return (true, "Categoria atualizada com sucesso.");
        }

        public async Task<(bool success, string message)> DeleteAsync(int id)
        {
            if (!await _repo.ExistsAsync(id))
                return (false, "Categoria não existe.");

            await _repo.DeleteAsync(id);
            return (true, "Categoria removida com sucesso.");
        }

        private CategoriaDTO EntityToDto(Categoria c)
        {
            return new CategoriaDTO
            {
                Id = c.Id,
                Nome = c.Nome,
                Descricao = c.Descricao
            };
        }
    }
}
