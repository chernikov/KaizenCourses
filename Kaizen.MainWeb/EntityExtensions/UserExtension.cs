using Kaizen.Core.Models;
using Kaizen.MainWeb.Dtos;

namespace Kaizen.MainWeb.EntityExtensions;

public static class UserExtension
{
    public static UserDto ToDto(this User source)
    {
        return new UserDto()
        {
            Email = source.Email,
            Password = source.Password
        };
    }
}
