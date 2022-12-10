using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPFinal.Models;

namespace TPFinal.Services
{
    public class MockDataStore : IDataStore<Mercadoria>
    {
        readonly List<Mercadoria> items;

        public MockDataStore()
        {
            items = new List<Mercadoria>()
            {
                new Mercadoria { Nome = "Nome", Peso = 5.0, NomeProdutor = "Nome produtor", EmailProdutor = "produtor@gmail.com", Ncm = "1" },
                new Mercadoria { Nome = "Nome", Peso = 5.0, NomeProdutor = "Nome produtor", EmailProdutor = "produtor@gmail.com", Ncm = "2" },
                new Mercadoria { Nome = "Nome", Peso = 5.0, NomeProdutor = "Nome produtor", EmailProdutor = "produtor@gmail.com", Ncm = "3" },
                new Mercadoria { Nome = "Nome", Peso = 5.0, NomeProdutor = "Nome produtor", EmailProdutor = "produtor@gmail.com", Ncm = "4" },
                new Mercadoria { Nome = "Nome", Peso = 5.0, NomeProdutor = "Nome produtor", EmailProdutor = "produtor@gmail.com", Ncm = "5" },
                new Mercadoria { Nome = "Nome", Peso = 5.0, NomeProdutor = "Nome produtor", EmailProdutor = "produtor@gmail.com", Ncm = "6" },
            };
        }

        public async Task<bool> AddItemAsync(Mercadoria mercadoria)
        {
            items.Add(mercadoria);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Mercadoria item)
        {
            var oldItem = items.Where((Mercadoria arg) => arg.Ncm == item.Ncm).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string ncm)
        {
            var oldItem = items.Where((Mercadoria arg) => arg.Ncm == ncm).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Mercadoria> GetItemAsync(string ncm)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Ncm == ncm));
        }

        public async Task<IEnumerable<Mercadoria>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}