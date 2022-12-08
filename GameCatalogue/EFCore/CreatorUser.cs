using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace GameCatalogue.EFCore
{
    [Authorize(Roles = "Creator")]
    public class Creator : User
    {
    }
}
