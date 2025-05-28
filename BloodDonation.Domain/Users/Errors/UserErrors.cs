using BloodDonation.Domain.Common;

namespace BloodDonation.Domain.Users.Errors;

public static class UserErrors
{
    public static readonly Error EmailNotUnique = Error.Conflict(
        "Users.EmailNotUnique",
        "The provided email is not unique");
    
    public static readonly Error AdminAlreadyExists = Error.Conflict(
        code: "User.AdminAlreadyExists",
        description: "Only one Admin is allowed in the system.");
}