namespace ATMCashDispenser.Handlers.Definition;
public abstract class MoneyHandler
{
    public MoneyHandler? nextHandler;

    public MoneyHandler()
    {
        nextHandler = null;
    }

    public void SetNextHandler(MoneyHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void Dispense(int amount);
}