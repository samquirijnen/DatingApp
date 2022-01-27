using System;
using System.Threading.Tasks;
using API.IRepositories;

namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IMessageRepository MessageRepository { get; }
        ILikesRepository LikesRepository { get; }
        Task<bool> Complete();

        bool HashChanges();
    }
}
