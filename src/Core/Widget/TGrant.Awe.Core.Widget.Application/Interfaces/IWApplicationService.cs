namespace Awe.Core.Widget.Application.Interfaces;

public interface IWApplicationService
{
    void Start(string[] args);
    Task StartAsync(string[] args);
    void Restart();
    string ProductInfo { get; }
}