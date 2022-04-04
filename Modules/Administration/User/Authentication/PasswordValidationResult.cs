namespace MovieDB.Administration
{
    public enum PasswordValidationResult
    {
        EmptyUsername,
        EmptyPassword,
        InactiveUser,
        UnknownSource,
        Throttle,
        DirectoryError,
        Invalid,
        Valid
    }
}