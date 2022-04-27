using Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IContato
    {
        Task<ContatoEntity> PostAsync(string Nome, string DataNascimento, string Sexo, int Idade, int Ativo);
        Task<IEnumerable<ContatoEntity>> GetAllAsync();
        Task<ContatoEntity> GetByIdAsync(int id);
        Task<ContatoEntity> DesativarAsync(int Id);
        Task<bool> DeleteAsync(int Id);
    }
}

