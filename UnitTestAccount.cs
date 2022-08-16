namespace New_HelloWorld_MSTest;

[TestClass]
public class UnitTestAccount
{
    [TestMethod]
    public void TestMethod_Dummy()
    {
        double expected = 10.1;
        double actual = 10;
        Assert.AreEqual(expected, actual, 0.10, "Accounts are correctly");
    }

    [TestMethod]
    public void TestMethod_Debit_WithValidAmount_UpdatesBalance()
    {
        // Arrange
        double beginningBalance = 11.99;
        double debitAmount = 4.55;
        double expected = 7.44;
        Account account = new("Mr. Bryan Walton", beginningBalance);

        // Act
        account.Debit(debitAmount);

        // Assert
        double actual = account.Balance;

        Console.WriteLine(expected);
        Console.WriteLine(actual);
        Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
    }

    [TestMethod]
    public void TestMethod_Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
    {
        // Arrange
        double beginningBalance = 11.99;
        double debitAmount = -100.00;
        Account account = new("Mr. Bryan Walton", beginningBalance);

        // Act and assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
    }
}