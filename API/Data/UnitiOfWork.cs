using System;
using System.Threading.Tasks;
using API.Interfaces;
using API.IRepositories;
using API.Repositories;
using AutoMapper;

namespace API.Data
{
    public class UnitiOfWork:IUnitOfWork
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UnitiOfWork(DataContext context ,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IUserRepository UserRepository =>
            new UserRepository(_context , _mapper);

        public IMessageRepository MessageRepository => new MessageRepository(_context,_mapper);

        public ILikesRepository LikesRepository => new LikesRepository(_context);

        public IPhotoRepository PhotoRepository => new PhotoRepository(_context);

        public async Task<bool> Complete()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public bool HashChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }
    }
}
