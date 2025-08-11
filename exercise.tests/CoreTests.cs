namespace exercise.tests;

using exercise.main;

public class Tests
{
    [Test]
    public void AddProductToBasketTest()
    {
        Basket basket = new Basket();
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
}