using Mundo_disney.Models.DataModels;

namespace Mundo_disney.Services
{
    public interface IUsersServices
    {
        IEnumerable<Users> GetUsers();
        Users GetUsersById(int id);
    }
}
