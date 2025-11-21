using ATMCashDispenser.Handlers.Definition;

namespace ATMCashDispenser.Handlers.Implementation;
public class FiveHundredHandler(int numNotes) : MoneyHandler
{
    int numNotes = numNotes;

    public override void Dispense(int amount)
    {
        int notesNeeded = amount / 500;

        if(notesNeeded > numNotes)
        {
            notesNeeded = numNotes;
            numNotes = 0;
        }
        else
        {
            numNotes -= notesNeeded;
        }

        if(notesNeeded > 0)
            Console.WriteLine("Dispensing " + notesNeeded + " * ₹500 notes");

        int remainingAmount = amount - (notesNeeded * 500);

        if(remainingAmount > 0)
        {
            if(nextHandler != null)
                nextHandler.Dispense(remainingAmount);
            else
                Console.WriteLine("Cannot dispense remaining amount: ₹" + remainingAmount);
        }

    }
}