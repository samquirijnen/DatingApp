using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTO;
using API.Entitties;
using API.Helpers;

namespace API.IRepositories
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(string currentUsername, string recipientUsername);
        Task<bool> SaveAllSync();
    }
}
