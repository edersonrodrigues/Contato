using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Infrastructure.Context;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ContatoService : IContato
    {
        RepositoryContato _repositoryUsuario;

        public ContatoService(DataContext context)
        {
            _repositoryUsuario = new RepositoryContato(context);
        }

        public async Task<IEnumerable<ContatoEntity>> GetAllAsync()
        {
            return await _repositoryUsuario.GetAllAsync();
        }

        public async Task<ContatoEntity> GetByIdAsync(int id)
        {
            return await _repositoryUsuario.GetByIdAsync(id);
        }

        public async Task<ContatoEntity> DesativarAsync(int Id)
        {
            return await _repositoryUsuario.DesativarAsync(Id);
        }

        public async Task<ContatoEntity> PostAsync(string Nome, string DataNascimento, string Sexo, int Idade, int Ativo)
        {
            DateTime nascimento = DateTime.Parse(DataNascimento);
            DateTime hoje = DateTime.Today;
            int anos = hoje.Year - nascimento.Year;

            if (anos > 18 && nascimento != hoje)
                return await _repositoryUsuario.PostAsync(Nome, DataNascimento, Sexo, Idade, Ativo);
            else
                return null;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            return await _repositoryUsuario.DeleteAsync(Id);
        }
    }
}

