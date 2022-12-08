using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace GameCatalogue.EFCore
{
    [Authorize(Roles = "Admin")]
    public class Admin : User
    {

    }
}
