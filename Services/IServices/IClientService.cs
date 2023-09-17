using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services.IServices
{
    public interface IClientService
    {
        IEnumerable<ClientDTO> GetAllClients();
        ClientDTO GetClientById(int id);
        void AddClient(ClientDTO client);
        void UpdateClient(ClientDTO client);
        void DeleteClient(int id);
    }
}
