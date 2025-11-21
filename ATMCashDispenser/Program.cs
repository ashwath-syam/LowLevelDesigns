using ATMCashDispenser.Handlers.Implementation;

// Create handlers for each denomination with available notes
THousandHandler thousandHandler = new(3);
FiveHundredHandler fiveHundredHandler = new(5);
HundredHandler hundredHandler = new(10);

// Set up the chain of responsibility
thousandHandler.SetNextHandler(fiveHundredHandler);
fiveHundredHandler.SetNextHandler(hundredHandler);  

int amountToDispense = 10000;

Console.WriteLine($"Dispensing amount: ₹{amountToDispense}");
thousandHandler.Dispense(amountToDispense);
