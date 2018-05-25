# SodaMachine
dCC Midterm

Assignment:
Create a soda machine that vends cans of soda - grap, orange & lemon flavors.  The machine should take in coins and return appropriate change.  Every coin (quarter, dime, nickel, penny) should be its own class.

When the buyer tries to buy an out of stock item, their money should be returned with no product vended.
When the buyer tries to buy and there is not enough coinage in the machine to provide the correct change, it should return their change and no product is vended.
When the buyer tries to buy and prodives more money than the total due, the appropriate change should be returned and the product vended.
When the buyer tries to buy with the exact change, the product should be vended.

The inventory of the machine is limited, as is the coinage of the machine.
Starting Coinage: 20 Quarters, 10 Dimes, 20 Nickels, 50 Pennies
Soda Prices: Grape $0.60, Orange $0.35, Lemon $0.06 (no starting invetory numbers were provided)

NO INTERNET ALLOWED!

Functionality Comments:
Create a new soda machine with the SodaMachineSetup.New() statice class & method.

Payment/Change:
As no internet was allowed I could not find an eligant solution to returning the change and the vended product (possiblely using out in the arguments).  As such, when calling SellTransaction(), the list of money that is provided will be cleared and then any change due will be placed in the list.  The method will return the vended product, if any.
