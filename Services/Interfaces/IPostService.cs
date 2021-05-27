using AngularProject.Models;
using AngularProject.Models.Db;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularProject.Services.Interfaces
{
    public interface IPostService
    {
        Task<bool> AddPostAsync(string message, int chanelID, User user);
        Task<bool> DeleteAsync(int postID);
        Task<Post> GetAsync(int postID);
        Task<IEnumerable<Post>> GetAllPosts();
        Task<bool> EditAsync(Post post);
        Task<int> CountChanelPostAsync(int chanelID);
    }
}
