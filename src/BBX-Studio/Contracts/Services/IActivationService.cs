namespace BBX_Studio.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
