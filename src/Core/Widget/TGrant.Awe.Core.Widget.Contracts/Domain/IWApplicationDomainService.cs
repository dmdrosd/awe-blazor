namespace TGrant.Awe.Core.Widget.Contracts.Domain;

public interface IWApplicationDomainService
{
    void Start(string[] args);
    Task StartAsync(string[] args);
    void Restart();
    string ProductInfo { get; }
}