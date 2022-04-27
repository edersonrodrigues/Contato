using Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Service
{
    public class ContatoServiceFake : IContato
    {
        public ContatoServiceFake()
        {

        }

        public Task<IEnumerable<ContatoEntity>> GetAllAsync()
        { 
            List<ContatoEntity> lstContatoEntity = new List<ContatoEntity>();
            ContatoEntity item = new ContatoEntity();
            item.Id = 1;
            item.Nome = "Ederson";
            item.DataNascimento = DateTime.Parse("04/07/1985");
            item.Sexo = "Masculino";
            item.Idade = 36;
            item.Ativo = 1;

            lstContatoEntity.Add(item);

            return null;
        }

        public Task<bool> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ContatoEntity> DesativarAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ContatoEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ContatoEntity> PostAsync(string Nome, string DataNascimento, string Sexo, int Idade, int Ativo)
        {
            throw new NotImplementedException();
        }
    }
}
