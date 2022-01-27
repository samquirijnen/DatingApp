using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTO;
using API.Entitties;

namespace API.IRepositories
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<PhotoForApprovalDto>> GetUnapprovedPhotos();
        Task<Photo> GetPhotoById(int id);
        void RemovePhoto(Photo photo);
    }
}
