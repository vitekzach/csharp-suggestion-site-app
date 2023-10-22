using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
namespace SuggestionAppLibrary.DataAccess;

public interface IStatusData
{
    Task CreateStatus(StatusModel status);
    Task<List<StatusModel>> GetAllStatuses();
}
