using ASPNETCore_Practice.Models.DTO;
using ASPNETCore_Practice.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services
{
    public class FakeClientService : IClientService
    {
        private List<ClientDTO> clients;
        private int nextId = 1;

        public FakeClientService()
        {
            // Инициализируйте список clients с примерами объектов
            clients = new List<ClientDTO>
        {
            new ClientDTO { Id = nextId++, FullName = "John Doe", Phone = "123-456-7890", CountryId = 1 },
            new ClientDTO { Id = nextId++, FullName = "Jane Smith", Phone = "987-654-3210", CountryId = 2 },
            new ClientDTO { Id = nextId++, FullName = "Alice Johnson", Phone = "555-123-4567", CountryId = 3 }
        };
        }

        public IEnumerable<ClientDTO> GetAllClients()
        {
            return clients;
        }

        public ClientDTO GetClientById(int id)
        {
            return clients.FirstOrDefault(c => c.Id == id);
        }

        public void AddClient(ClientDTO client)
        {
            client.Id = nextId++;
            clients.Add(client);
        }

        public void UpdateClient(ClientDTO updatedClient)
        {
            var existingClient = clients.FirstOrDefault(c => c.Id == updatedClient.Id);
            if (existingClient != null)
            {
                existingClient.FullName = updatedClient.FullName;
                existingClient.Phone = updatedClient.Phone;
                existingClient.CountryId = updatedClient.CountryId;
            }
        }

        public void DeleteClient(int id)
        {
            var clientToDelete = clients.FirstOrDefault(c => c.Id == id);
            if (clientToDelete != null)
            {
                clients.Remove(clientToDelete);
            }
        }
    }
}
