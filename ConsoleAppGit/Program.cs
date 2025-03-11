



//Write a c# program demonstarte reverse of a string

//public class ReverseString
//{
//    public static void Main(String[] args)
//    {
//        string str = "Enjoy code";
//        char[] charArray = str.ToCharArray();
//        Array.Reverse(charArray);
//        string reverseString = new string(charArray);
//        Console.WriteLine("Reverse of string is: " + reverseString);
//    }
//}


//modify below program factory design pattern in c# for cards, use interface for better programing , Use DI for factory class 

public interface ICard
{
    string CardType { get; }
    int CreditLimit { get; }
    int AnnualCharge { get; }
}

public class PlatinumCard : ICard
{
    public string CardType => "Platinum";
    public int CreditLimit => 35000;
    public int AnnualCharge => 2000;
}



public class GoldCard : ICard
{
    public string CardType => "Gold";
    public int CreditLimit => 25000;
    public int AnnualCharge => 1500;
}


public class TitaniumCard : ICard
{
    public string CardType => "Titanium";
    public int CreditLimit => 45000;
    public int AnnualCharge => 3000;
}

public class CardFactory
{
    public ICard GetCard(string cardType)
    {
        switch (cardType)
        {
            case "Platinum":
                return new PlatinumCard();
            case "Gold":
                return new GoldCard();
            case "Titanium":
                return new TitaniumCard();
            default:
                return null;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CardFactory cardFactory = new CardFactory();
        ICard card = cardFactory.GetCard("Platinum");
        Console.WriteLine("Card Type: " + card.CardType);
        Console.WriteLine("Credit Limit: " + card.CreditLimit);
        Console.WriteLine("Annual Charge: " + card.AnnualCharge);
    }
}

