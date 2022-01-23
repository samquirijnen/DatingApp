using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTO;
using API.Entitties;
using API.Helpers;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUsersLikes(LikesParams likesParams);
    }
}
