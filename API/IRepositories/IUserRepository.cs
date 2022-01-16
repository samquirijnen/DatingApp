using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTO;
using API.Entitties;

namespace API.IRepositories
{
    public interface IUserRepository
    {
        void Updat(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GeetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberAsync(string username);
    }
}
