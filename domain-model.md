|Classes|Methods/Properties|Scenario|Output|
|-----|------------------|--------|------|
|Basket|Add(IProduct product)|Add specific type of bagel to basket|`bool`|
|Basket|Remove(IProduct product)|Remove bagel from basket|`bool`|
|Basket|IsFull|Check if basket is full|`bool`|
|Basket|ChangeCapacity(int newCapacity)|Change capacity of basket|`bool`|
|Basket|Remove(IProcut product)|When attempting to remove item, notify if it does not exist|`bool`|
|Basket|CalculateTotalCost|Calculate total cost of items in basket|`double`|
|IProduct|Price|See the cost of a bagel|`double`|
|Bagel|AddFilling(Filling filling)|Add filling to bagel order|`bool`|
|Inventory|AllFillingsPrice|See cost of each filling|`Dictionary<string, double>`|
|Inventory|InStock(IProduct product)|Only allow costumers to order items from inventory|`bool`|