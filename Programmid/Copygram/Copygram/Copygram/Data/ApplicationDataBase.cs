using Copygram.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Copygram.Data
{
    public class ApplicationDatabase
    {
        SQLiteAsyncConnection _dbContext;
        public ApplicationDatabase(string dbPath)
        {
            _dbContext = new SQLiteAsyncConnection(dbPath);
            _dbContext.CreateTableAsync<Post>().Wait();
            _dbContext.CreateTableAsync<User>().Wait();
        }
        public async Task<List<Post>> GetPostsAsync()
        {
            return await _dbContext.Table<Post>().ToListAsync();
        }
        public async Task<Post> GetPostAsync(int id)
        {
            return await _dbContext.Table<Post>()
                           .Where(x => x.Id == id)
                           .FirstOrDefaultAsync();
        }
        public async Task<int> SavePostAsync(Post Post)
        {
            if (Post.Id != 0)
            {
                return await _dbContext.UpdateAsync(Post);
            }
            else
            {
                return await _dbContext.InsertAsync(Post);
            }
        }
        public async Task<int> DeletePostAsync(Post Post)
        {
            return await _dbContext.DeleteAsync(Post);
        }

        // Users
        public async Task<int> SaveUserAsync(User User)
        {
            if (User.Id != 0)
            {
                return await _dbContext.UpdateAsync(User);
            }
            else
            {
                return await _dbContext.InsertAsync(User);
            }
        }
    }
}
