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

        // TODO: Update later when fillings are implemented
        Assert.That(totalCost, Is.EqualTo(targetTotalBasketCost));
    }

    [Test] // User Story 7
    public void SeeProductPriceTest()
    {
        double price = 0.49;
        IProduct onionBagel = new Bagel("BGLO", price, "Bagel", "Onion");

        Assert.That(onionBagel.Price, Is.EqualTo(price));   

    }
}