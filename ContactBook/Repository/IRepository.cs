using ContactBook.DTOs;
using ContactBook.Services;

namespace ContactBook.Repository
{
    public interface IRepository
    {
        IEnumerable<AppUserDTO> GetAll(PaginParameter usersParameter);
        Task<AppUserDTO> GetByIdAsync(string Id);
        Task<AppUserDTO> GetByEmailAsync(string email);
        Task<bool> CreateUserAsync(AppUserDTO appUser);
        Task<bool> DeleteByIdAsync(string Id);
        Task<bool> UpdateUserPhotoAsync(string userId, string imageUrl, Stream photoStream);
        Task<List<AppUserDTO>> SearchUsersAsync(string term);
    }
}
