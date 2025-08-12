using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests;
using exercise.main;
public class ExtensionTest
{
    [Test] // Extension 1 - Discounts
    public void SixBagelsSpecialOfferTest()
    {
        int capacity = 10;
        Inventory inventory = new Inventory();
        Basket basket = new Basket(capacity, inventory);

        Bagel onionBagel1 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel2 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel3 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel4 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel5 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel6 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel plainBagel1 = new Bagel("BGLP", 0.39, "Bagel", "Plain");
        Bagel plainBagel2 = new Bagel("BGLP", 0.39, "Bagel", "Plain");
        Filling baconFilling = new Filling("FILB", 0.12, "Filling", "Bacon");

        onionBagel1.AddFilling(baconFilling);
        basket.Add(onionBagel1);
        basket.Add(onionBagel2);
        basket.Add(onionBagel3);
        basket.Add(onionBagel4);
        basket.Add(onionBagel5);
        basket.Add(onionBagel6);
        basket.Add(plainBagel1);
        basket.Add(plainBagel2);

        double sixBaglesPrice = 2.49;
        double expectedTotal = sixBaglesPrice + 2 * 0.39 + 0.12;

        double actualTotal = basket.CalculateTotalCost();

        Assert.That(actualTotal, Is.EqualTo(expectedTotal));
    }

    [Test]
    public void TwelveBagelsSpecialOfferTest()
    {
        int capacity = 15;
        Inventory inventory = new Inventory();
        Basket basket = new Basket(capacity, inventory);

        Bagel onionBagel1 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel2 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel3 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel4 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel5 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel6 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel7 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel8 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel9 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel10 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel11 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel12 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel plainBagel1 = new Bagel("BGLP", 0.39, "Bagel", "Plain");
        Bagel plainBagel2 = new Bagel("BGLP", 0.39, "Bagel", "Plain");
        Filling baconFilling = new Filling("FILB", 0.12, "Filling", "Bacon");

        onionBagel1.AddFilling(baconFilling);
        basket.Add(onionBagel1);
        basket.Add(onionBagel2);
        basket.Add(onionBagel3);
        basket.Add(onionBagel4);
        basket.Add(onionBagel5);
        basket.Add(onionBagel6);
        basket.Add(onionBagel7);
        basket.Add(onionBagel8);
        basket.Add(onionBagel9);
        basket.Add(onionBagel10);
        basket.Add(onionBagel11);
        basket.Add(onionBagel12);
        basket.Add(plainBagel1);
        basket.Add(plainBagel2);

        double twelveBaglesPrice = 3.99;
        double expectedTotal = twelveBaglesPrice + 2 * 0.39 + 0.12;

        double actualTotal = basket.CalculateTotalCost();

        Assert.That(actualTotal, Is.EqualTo(expectedTotal));
    }

    [Test]
    public void CoffeeAndBagelSpecialOfferTest()
    {
        int capacity = 10;
        Inventory inventory = new Inventory();
        Basket basket = new Basket(capacity, inventory);

        Bagel onionBagel1 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Filling baconFilling = new Filling("FILB", 0.12, "Filling", "Bacon");
        Coffee blackCoffee = new Coffee("COFB", 0.99, "Coffee", "Black");

        onionBagel1.AddFilling(baconFilling);

        basket.Add(onionBagel1);
        basket.Add(blackCoffee);

        double coffeeAndBagelPrice = 1.25;
        double expectedTotal = coffeeAndBagelPrice + 0.12;

        double actualTotal = basket.CalculateTotalCost();

        Assert.That(actualTotal, Is.EqualTo(expectedTotal));
    }

    [Test]
    public void MultipleSpecialOffersTest()
    {
        int capacity = 15;
        Inventory inventory = new Inventory();
        Basket basket = new Basket(capacity, inventory);

        Bagel onionBagel1 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel2 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel3 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel4 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel5 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel6 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel7 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel8 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel9 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel10 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel11 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Bagel onionBagel12 = new Bagel("BGLO", 0.49, "Bagel", "Onion");
        Coffee blackCoffee = new Coffee("COFB", 0.99, "Coffee", "Black");

        basket.Add(onionBagel1);
        basket.Add(onionBagel2);
        basket.Add(onionBagel3);
        basket.Add(onionBagel4);
        basket.Add(onionBagel5);
        basket.Add(onionBagel6);
        basket.Add(onionBagel7);
        basket.Add(onionBagel8);
        basket.Add(onionBagel9);
        basket.Add(onionBagel10);
        basket.Add(onionBagel11);
        basket.Add(onionBagel12);
        basket.Add(blackCoffee);

        double twelveBaglesPrice = 2.49;
        double expectedTotalPrice = twelveBaglesPrice + 0.99;

        double actualTotalPrice = basket.CalculateTotalCost();

        Assert.That(actualTotalPrice, Is.EqualTo(expectedTotalPrice));
    }
}
