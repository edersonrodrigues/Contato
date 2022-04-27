using Domain.Entities;
using Domain.Interfaces.Services;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class RepositoryContato : IContato
    {
        protected readonly DataContext _context;

        public RepositoryContato(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ContatoEntity>> GetAllAsync()
        {
            try
            {
                return await _context.Contato
                .Where(x => x.Ativo == 1)
               .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<ContatoEntity> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Contato
               .Where(x => x.Id == id && x.Ativo == 1)
               .SingleOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ContatoEntity> PostAsync(string Nome, string DataNascimento, string Sexo, int Idade, int Ativo)
        {
            ContatoEntity obj = new ContatoEntity {Nome = Nome, DataNascimento = DateTime.Parse(DataNascimento), Sexo = Sexo, Idade = Idade, Ativo = Ativo };

            try
            {
                _context.Add(obj);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return obj;
        }

        public async Task<ContatoEntity> DesativarAsync(int Id)
        {
            ContatoEntity obj = await GetByIdAsync(Id);

            try
            {
                if (obj == null)
                {
                    return null;
                }

                obj.Ativo = 0;

                _context.Contato.Update(obj);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return obj;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            try
            {
                var result = await _context.Contato.SingleOrDefaultAsync(p => p.Id.Equals(Id));

                if (result == null)
                {
                    return false;
                }

                _context.Remove(result);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}