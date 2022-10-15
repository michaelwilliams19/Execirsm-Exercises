using NUnit.Framework;

public class InterestIsInterestingTests
{
    [Test]
    public void Minimal_first_interest_rate()
    {
        Assert.AreEqual(0.5f, SavingsAccount.InterestRate(0m));
    }

    [Test]
    public void Tiny_first_interest_rate()
    {
        Assert.AreEqual(0.5f, SavingsAccount.InterestRate(0.000001m));
    }

    [Test]
    public void Maximum_first_interest_rate()
    {
        Assert.AreEqual(0.5f, SavingsAccount.InterestRate(999.9999m));
    }

    [Test]
    public void Minimal_second_interest_rate()
    {
        Assert.AreEqual(1.621f, SavingsAccount.InterestRate(1_000.0m));
    }

    [Test]
    public void Tiny_second_interest_rate()
    {
        Assert.AreEqual(1.621f, SavingsAccount.InterestRate(1_000.0001m));
    }

    [Test]
    public void Maximum_second_interest_rate()
    {
        Assert.AreEqual(1.621f, SavingsAccount.InterestRate(4_999.9990m));
    }

    [Test]
    public void Minimal_third_interest_rate()
    {
        Assert.AreEqual(2.475f, SavingsAccount.InterestRate(5_000.0000m));
    }

    [Test]
    public void Tiny_third_interest_rate()
    {
        Assert.AreEqual(2.475f, SavingsAccount.InterestRate(5_000.0001m));
    }

    [Test]
    public void Large_third_interest_rate()
    {
        Assert.AreEqual(2.475f, SavingsAccount.InterestRate(5_639_998.742909m));
    }

    [Test]
    public void Rate_on_minimal_negative_balance()
    {
        Assert.AreEqual(3.213f, SavingsAccount.InterestRate(-0.000001m));
    }

    [Test]
    public void Rate_on_small_negative_balance()
    {
        Assert.AreEqual(3.213f, SavingsAccount.InterestRate(-0.123m));
    }

    [Test]
    public void Rate_on_regular_negative_balance()
    {
        Assert.AreEqual(3.213f, SavingsAccount.InterestRate(-300.0m));
    }

    [Test]
    public void Rate_on_large_negative_balance()
    {
        Assert.AreEqual(3.213f, SavingsAccount.InterestRate(-152964.231m));
    }

    [Test]
    public void Interest_on_negative_balance()
    {
        Assert.AreEqual(-321.3m, SavingsAccount.Interest(-10000.0m));
    }

    [Test]
    public void Interest_on_small_balance()
    {
        Assert.AreEqual(2.77775m, SavingsAccount.Interest(555.55m));
    }

    [Test]
    public void Interest_on_medium_balance()
    {
        Assert.AreEqual(81.0498379m, SavingsAccount.Interest(4999.99m));
    }

    [Test]
    public void Interest_on_large_balance()
    {
        Assert.AreEqual(856.3698m, SavingsAccount.Interest(34600.80m));
    }

    [Test]
    public void Annual_balance_update_for_empty_start_balance()
    {
        Assert.AreEqual(0.0000m, SavingsAccount.AnnualBalanceUpdate(0.0m));
    }

    [Test]
    public void Annual_balance_update_for_small_positive_start_balance()
    {
        Assert.AreEqual(0.000001005m, SavingsAccount.AnnualBalanceUpdate(0.000001m));
    }

    [Test]
    public void Annual_balance_update_for_average_positive_start_balance()
    {
        Assert.AreEqual(1016.210000m, SavingsAccount.AnnualBalanceUpdate(1_000.0m));
    }

    [Test]
    public void Annual_balance_update_for_large_positive_start_balance()
    {
        Assert.AreEqual(1016.210101621m, SavingsAccount.AnnualBalanceUpdate(1_000.0001m));
    }

    [Test]
    public void Annual_balance_update_for_huge_positive_start_balance()
    {
        Assert.AreEqual(920352587.26744292868451875m, SavingsAccount.AnnualBalanceUpdate(898124017.826243404425m));
    }

    [Test]
    public void Annual_balance_update_for_small_negative_start_balance()
    {
        Assert.AreEqual(-0.12695199m, SavingsAccount.AnnualBalanceUpdate(-0.123m));
    }

    [Test]
    public void Annual_balance_update_for_large_negative_start_balance()
    {
        Assert.AreEqual(-157878.97174203m, SavingsAccount.AnnualBalanceUpdate(-152964.231m));
    }

    [Test]
    public void Years_before_desired_balance_for_small_start_balance()
    {
        Assert.AreEqual(47, SavingsAccount.YearsBeforeDesiredBalance(100.0m, 125.80m));
    }

    [Test]
    public void Years_before_desired_balance_for_average_start_balance()
    {
        Assert.AreEqual(6, SavingsAccount.YearsBeforeDesiredBalance(1_000.0m, 1_100.0m));
    }

    [Test]
    public void Years_before_desired_balance_for_large_start_balance()
    {
        Assert.AreEqual(5, SavingsAccount.YearsBeforeDesiredBalance(8_080.80m, 9_090.90m));
    }

    [Test]
    public void Years_before_desired_balance_for_large_different_between_start_and_target_balance()
    {
        Assert.AreEqual(85, SavingsAccount.YearsBeforeDesiredBalance(2_345.67m, 12_345.6789m));
    }
}
