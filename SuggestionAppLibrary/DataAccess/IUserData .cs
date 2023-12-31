using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace SuggestionAppLibrary.DataAccess;

public interface IUserData
{
    Task CreateUser(UserModel user);
    Task<UserModel> GetUser(string id);
    Task<UserModel> GetUserFromAuthentication(string objectId);
    Task<List<UserModel>> GetUsersAsync();
    Task UpdateUser(UserModel user);
}
