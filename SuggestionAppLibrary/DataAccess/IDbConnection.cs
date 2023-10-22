using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
namespace SuggestionAppLibrary.DataAccess;

public interface IDbConnection
{
    string DbName { get; }
    string CategoryCollectionName { get; }
    string StatusCollectionName { get; }
    string SuggestionCollectionName { get; }
    string UserCollectionName { get; }
    MongoClient Client { get; }
    IMongoCollection<CategoryModel> CategoryCollection { get; }
    IMongoCollection<StatusModel> StatusCollection { get; }
    IMongoCollection<UserModel> UserCollection { get; }
    IMongoCollection<SuggestionModel> SuggestionCollection { get; }
}