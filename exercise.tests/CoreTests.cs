namespace exercise.tests;

using exercise.main;

public class Tests
{
    [Test] // User Story 1
    public void AddProductToBasketTest()
    {
        int capacity = 10;
        Basket basket = new Basket(capacity);
        IProduct bagel = new Bagel();
        IProduct coffee = new Coffee();
        IProduct filling = new Filling();

        bool success1 = basket.Add(bagel);
        bool success2 = basket.Add(coffee);
        // Don't want to allow directly adding filling.
        // Need to be added via bagel.
        bool fail = basket.Add(filling);

        Assert.True(basket.Items.Contains(bagel));
        Assert.True(success1);
        Assert.True(basket.Items.Contains(coffee));
        Assert.True(success2);
        Assert.False(basket.Items.Contains(filling));
        Assert.False(fail);
    }

    [Test] // User Story 2 and 5
    public void RemoveProductFromBasketTest()
    {
        int capacity = 10;
        Basket basket = new Basket(capacity);
        IProduct onionBagel = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        IProduct plainBagel = new Bagel("BGLp", 0.39, "Bagel", "Plain");

        basket.Add(onionBagel);

        bool success = basket.Remove(onionBagel);
        bool fail = basket.Remove(plainBagel);

        Assert.True(success);
        Assert.False(fail);
    }

    [Test] // User Story 3
    public void BasketIsFullTest()
    {
        int capacity = 2;
        Basket basket = new Basket(capacity);
        IProduct onionBagel = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        IProduct plainBagel = new Bagel("BGLP", 0.39, "Bagel", "Plain");
        IProduct everythingBagel = new Bagel("BGLE", 0.49, "Bagel", "Everything");

        bool success1 = basket.Add(onionBagel);
        bool success2 = basket.Add(plainBagel);
        bool isFull = basket.IsFull;
        bool fail = basket.Add(everythingBagel);

        Assert.True(success1);
        Assert.True(success2);
        Assert.True(isFull);
        Assert.False(fail);
    }

    [Test] // User Story 4
    public void IncreaseCapacityTest()
    {
        int initialCapacity = 2;
        Basket basket = new Basket(initialCapacity);
        IProduct onionBagel = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        IProduct plainBagel = new Bagel("BGLP", 0.39, "Bagel", "Plain");
        IProduct everythingBagel = new Bagel("BGLE", 0.49, "Bagel", "Everything");

        basket.Add(onionBagel);
        basket.Add(plainBagel);
        bool fail = basket.Add(everythingBagel);

        int newInvalidCapacity = 1;
        bool capacityNotIncreased = basket.ChangeCapacity(newInvalidCapacity);
        int newCapacity = 4;
        bool capacityIncreased = basket.ChangeCapacity(newCapacity);
        bool success = basket.Add(everythingBagel);
        bool isFull = basket.IsFull;

        Assert.False(fail);
        Assert.False(capacityNotIncreased);
        Assert.True(capacityIncreased);
        Assert.True(success);
        Assert.False(isFull);
        Assert.That(basket.Capacity, Is.EqualTo(newCapacity));
    }

    [Test] // User Story 6
    public void CalculateTotalBasketCostTest()
    {
        int capacity = 10;
        double targetTotalBasketCost = 6;

        Basket basket = new Basket(capacity);
        IProduct onionBagel = new Bagel("BGLO", 1, "Bagel", "Onion");
        IProduct plainBagel = new Bagel("BGLP", 2, "Bagel", "Plain");
        IProduct everythingBagel = new Bagel("BGLE", 3, "Bagel", "Everything");

        basket.Add(onionBagel);
        basket.Add(plainBagel);
        basket.Add(everythingBagel);

        double totalCost = basket.CalculateTotalCost();

        Assert.That(totalCost, Is.EqualTo(targetTotalBasketCost));
    }

    [Test] // User Story 7
    public void SeeProductPriceTest()
    {
        double price = 0.49;
        IProduct onionBagel = new Bagel("BGLO", price, "Bagel", "Onion");

        Assert.That(onionBagel.Price, Is.EqualTo(price));   

    }

    [Test] // User Story 8
    public void AddFillingToBagelTest()
    {
        int capacity = 10;
        Basket basket = new Basket(capacity);
        Bagel onionBagel = new Bagel("BGLO", 1, "Bagel", "Onion");
        Bagel plainBagel = new Bagel("BGLP", 2, "Bagel", "Plain");
        Filling baconFilling = new Filling("FILB", 2, "Filling", "Bacon");
        Filling eggFilling = new Filling("FILE", 1, "Filling", "Egg");

        bool success1 = onionBagel.AddFilling(baconFilling);
        bool success2 = onionBagel.AddFilling(eggFilling);

        Assert.That(onionBagel.Fillings.Count, Is.EqualTo(2));
        Assert.That(success1 && success2, Is.True);
        Assert.That(plainBagel.Fillings.Count, Is.EqualTo(0));
    }

    [Test]
    public void CalculateTotalCostWithFillingTest()
    {
        int capacity = 10;
        double targetTotalCost = 9;

        Basket basket = new Basket(capacity);

        Bagel onionBagel = new Bagel("BGLO", 1, "Bagel", "Onion");
        Bagel plainBagel = new Bagel("BGLP", 2, "Bagel", "Plain");
        Bagel everythingBagel = new Bagel("BGLE", 3, "Bagel", "Everything");

        Filling baconFilling = new Filling("FILB", 2, "Filling", "Bacon");
        Filling eggFilling = new Filling("FILE", 1, "Filling", "Egg");

        onionBagel.AddFilling(baconFilling);
        plainBagel.AddFilling(eggFilling);

        basket.Add(onionBagel);
        basket.Add(plainBagel);
        basket.Add(everythingBagel);

        double totalCost = basket.CalculateTotalCost();

        Assert.That(totalCost, Is.EqualTo(targetTotalCost));
    }

    [Test]
    public void AddProductWithFillingToBasketTest()
    {
        int capacity = 5;
        Basket basket = new Basket(capacity);

        Bagel onionBagel = new Bagel("BGLO", 1, "Bagel", "Onion");
        Bagel plainBagel = new Bagel("BGLP", 2, "Bagel", "Plain");

        Filling baconFilling = new Filling("FILB", 2, "Filling", "Bacon");

        onionBagel.AddFilling(baconFilling);

        basket.Add(onionBagel);
        basket.Add(plainBagel);

        Assert.That(basket.Items.Count, Is.EqualTo(3));
    }

    [Test]
    public void RemoveProductWithFillingFromBasketTest()
    {
        int capacity = 5;
        Basket basket = new Basket(capacity);

        Bagel onionBagel = new Bagel("BGLO", 1, "Bagel", "Onion");
        Bagel plainBagel = new Bagel("BGLP", 2, "Bagel", "Plain");

        Filling baconFilling = new Filling("FILB", 2, "Filling", "Bacon");

        onionBagel.AddFilling(baconFilling);

        basket.Add(onionBagel);
        basket.Add(plainBagel);

        basket.Remove(onionBagel);

        Assert.That(basket.Items.Count, Is.EqualTo(1));
    }

    [Test] // User Story 9
    public void GetCostOfEachFillingTest()
    {
        Inventory inventory = new Inventory();
        int numberOfFillings = 6;

        Dictionary<string, double> allFillingsPrice = inventory.AllFillingsPrice();

        Assert.That(allFillingsPrice.Values.Count, Is.EqualTo(numberOfFillings));
    }

    [Test] // User story 10
    public void OnlyAddInStockItemsToBasket()
    {
        int capacity = 5;

        Inventory inventory = new Inventory();
        Basket basket = new Basket(capacity, inventory);

        Bagel onionBagel = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel nonExisting1 = new Bagel("BGLQ", 0.49, "Bagel", "Onion");
        Bagel nonExisting2 = new Bagel("BGLO", 0.49, "Bag", "Onion");
        Bagel nonExisting3 = new Bagel("BGLO", 1.49, "Bagel", "Onion");
        Bagel nonExisting4 = new Bagel("BGLO", 0.49, "Bagel", "Cheese");

        bool success = basket.Add(onionBagel);
        bool fail1 = basket.Add(nonExisting1);
        bool fail2 = basket.Add(nonExisting2);
        bool fail3 = basket.Add(nonExisting3);
        bool fail4 = basket.Add(nonExisting4);

        Assert.That(success, Is.True);
        Assert.That(fail1, Is.False);
        Assert.That(fail2, Is.False);
        Assert.That(fail3, Is.False);
        Assert.That(fail4, Is.False);
    }
}