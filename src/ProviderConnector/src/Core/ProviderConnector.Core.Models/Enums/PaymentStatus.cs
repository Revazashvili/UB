namespace ProviderConnector.Core.Models.Enums;

public enum PaymentStatus
{
    SuccessOrDuplicateTransaction = 0,
    ClientNotFound = -1,
    InvalidHash = -2,
    IncorrectAmount = -3,
    ProvidingTechnicalError = -4,
    UndefinedError = -13
}