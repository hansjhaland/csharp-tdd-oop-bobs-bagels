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

        basket.Add(bagel);
        basket.Add(coffee);
        // Don't want to allow directly adding filling.
        // Need to be added via bagel.
        basket.Add(filling);

        Assert.True(basket.Items.Contains(bagel));
        Assert.True(basket.Items.Contains(coffee));
        Assert.False(basket.Items.Contains(filling));
    }
}