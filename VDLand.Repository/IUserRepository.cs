using VDLand.Model;

namespace VDLand.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> Query();

    }
}
