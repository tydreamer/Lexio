namespace Lexio.Interfaces;

public interface IDiscardableChanges
{
    bool DataChanged { get; }
    void ConfirmDiscarding();
}