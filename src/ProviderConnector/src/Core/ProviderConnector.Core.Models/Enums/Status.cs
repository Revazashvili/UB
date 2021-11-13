namespace ProviderConnector.Core.Models.Enums;

public enum Status
{
    Success = 0,
    Error = 1,
    NotFound = 2,
    BalanceNotAvailable = 3,
    Unknown = 100,
    PhoneIncorrect = 6,
    LimitExceeded = 7,
    UnderAged = 8,
    ServiceUnavailable = 9,
    IncorrectParameterPattern = 10,
    AlreadyReversed = 11,
    AccountProblem = 12
}