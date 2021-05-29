using AngularProject.Context;
using AngularProject.Models;
using AngularProject.Models.Db;
using AngularProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularProject.Services
{
    public class PostService : IPostService
    {
        private readonly AngularProjectContext _context;

        public PostService(AngularProjectContext context)
        {
            _context = context;
        }

        public Task<bool> AddPostAsync(string message, int chanelID, User user)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountChanelPostAsync(int chanelID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int postID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        public Task<Post> GetAsync(int postID)
        {
            throw new NotImplementedException();
        }
    }
}
