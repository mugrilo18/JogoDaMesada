using UnityEngine;

public class Bank : MonoBehaviour
{
    Player player;
    private int hundredMoney;
    private int fiveHundredMoney;
    private int thousandMoney;
    private int fiveThousandMoney;
    private int tenThousandMoney;

    void Awake()
    {
        player = GetComponent<Player>();
    }

    public string TotalMoney()
    {
        int totalMoney;

        hundredMoney = player.hundredMoneyPlayer * 100;
        fiveHundredMoney = player.fiveHundredMoneyPlayer * 500;
        thousandMoney = player.thousandMoneyPlayer * 1000;
        fiveThousandMoney = player.fiveThousandMoneyPlayer * 5000;
        tenThousandMoney = player.tenThousandMoneyPlayer * 10000;

        totalMoney = hundredMoney + fiveHundredMoney + thousandMoney + fiveThousandMoney + tenThousandMoney;
        Debug.Log("Dinheiro total: R$" + totalMoney + ",00");

        return totalMoney.ToString();
    }

    public void ConvertToHundred()
    {
        if (player.fiveHundredMoneyPlayer >= 1)
        {
            player.fiveHundredMoneyPlayer -= 1;
            player.hundredMoneyPlayer += 5;
        }

        if (player.thousandMoneyPlayer >= 1)
        {
            player.thousandMoneyPlayer -= 1;
            player.hundredMoneyPlayer += 10;
        }

        if (player.fiveThousandMoneyPlayer >= 1)
        {
            player.fiveThousandMoneyPlayer -= 1;
            player.hundredMoneyPlayer += 50;
        }

        if (player.tenThousandMoneyPlayer >= 1)
        {
            player.tenThousandMoneyPlayer -= 1;
            player.hundredMoneyPlayer += 100;
        }

        Debug.Log("Todas as notas convertidas para R$100,00");
        Debug.Log(player.hundredMoneyPlayer + "X R$100,00 \n" + player.fiveHundredMoneyPlayer + "X R$500,00 \n" + player.thousandMoneyPlayer + "X R$1000,00 \n" + player.fiveThousandMoneyPlayer + "X R$5000,00 \n" + player.tenThousandMoneyPlayer + "X R$10000,00 \n");


    }

    public void ConvertToFiveHundred()
    {
        if (player.hundredMoneyPlayer >= 5)
        {
            player.hundredMoneyPlayer -= 5;
            player.fiveHundredMoneyPlayer++;
        }

        if (player.thousandMoneyPlayer >= 1)
        {
            player.thousandMoneyPlayer -= 1;
            player.fiveHundredMoneyPlayer += 2;
        }

        if (player.fiveThousandMoneyPlayer >= 1)
        {
            player.fiveThousandMoneyPlayer -= 1;
            player.fiveHundredMoneyPlayer += 10;
        }

        if (player.tenThousandMoneyPlayer >= 1)
        {
            player.tenThousandMoneyPlayer -= 1;
            player.fiveHundredMoneyPlayer += 20;
        }

        Debug.Log("Todas as notas convertidas para R$500,00");
        Debug.Log(player.hundredMoneyPlayer + "X R$100,00 \n" + player.fiveHundredMoneyPlayer + "X R$500,00 \n" + player.thousandMoneyPlayer + "X R$1000,00 \n" + player.fiveThousandMoneyPlayer + "X R$5000,00 \n" + player.tenThousandMoneyPlayer + "X R$10000,00 \n");
    }

    public void ConvertToThousand()
    {
        if (player.hundredMoneyPlayer >= 10)
        {
            player.hundredMoneyPlayer -= 10;
            player.thousandMoneyPlayer++;
        }

        if (player.fiveHundredMoneyPlayer >= 2)
        {
            player.fiveHundredMoneyPlayer -= 2;
            player.thousandMoneyPlayer++;
        }

        if (player.fiveThousandMoneyPlayer >= 1)
        {
            player.fiveThousandMoneyPlayer -= 1;
            player.thousandMoneyPlayer += 5;
        }

        if (player.tenThousandMoneyPlayer >= 1)
        {
            player.tenThousandMoneyPlayer -= 1;
            player.thousandMoneyPlayer += 10;
        }

        Debug.Log("Todas as notas convertidas para R$1000,00");
        Debug.Log(player.hundredMoneyPlayer + "X R$100,00 \n" + player.fiveHundredMoneyPlayer + "X R$500,00 \n" + player.thousandMoneyPlayer + "X R$1000,00 \n" + player.fiveThousandMoneyPlayer + "X R$5000,00 \n" + player.tenThousandMoneyPlayer + "X R$10000,00 \n");
    }
    public void ConvertToFiveThousand()
    {
        if (player.hundredMoneyPlayer >= 50)
        {
            player.hundredMoneyPlayer -= 50;
            player.fiveThousandMoneyPlayer++;
        }

        if (player.fiveHundredMoneyPlayer >= 10)
        {
            player.fiveHundredMoneyPlayer -= 10;
            player.fiveThousandMoneyPlayer++;
        }

        if (player.thousandMoneyPlayer >= 5)
        {
            player.thousandMoneyPlayer -= 5;
            player.fiveThousandMoneyPlayer++;
        }

        if (player.tenThousandMoneyPlayer >= 1)
        {
            player.tenThousandMoneyPlayer -= 1;
            player.fiveThousandMoneyPlayer += 2;
        }

        Debug.Log("Todas as notas convertidas para R$5000,00");
        Debug.Log(player.hundredMoneyPlayer + "X R$100,00 \n" + player.fiveHundredMoneyPlayer + "X R$500,00 \n" + player.thousandMoneyPlayer + "X R$1000,00 \n" + player.fiveThousandMoneyPlayer + "X R$5000,00 \n" + player.tenThousandMoneyPlayer + "X R$10000,00 \n");
    }
    public void ConvertToTenThousand()
    {
        if (player.hundredMoneyPlayer >= 100)
        {
            player.hundredMoneyPlayer -= 100;
            player.tenThousandMoneyPlayer++;
        }

        if (player.fiveHundredMoneyPlayer >= 20)
        {
            player.fiveHundredMoneyPlayer -= 20;
            player.tenThousandMoneyPlayer++;
        }

        if (player.thousandMoneyPlayer >= 10)
        {
            player.thousandMoneyPlayer -= 10;
            player.tenThousandMoneyPlayer++;
        }
        
        if (player.fiveThousandMoneyPlayer >= 2)
        {
            player.fiveThousandMoneyPlayer -= 2;
            player.tenThousandMoneyPlayer++;
        }

        Debug.Log("Todas as notas convertidas para R$5000,00");
        Debug.Log(player.hundredMoneyPlayer + "X R$100,00 \n" + player.fiveHundredMoneyPlayer + "X R$500,00 \n" + player.thousandMoneyPlayer + "X R$1000,00 \n" + player.fiveThousandMoneyPlayer + "X R$5000,00 \n" + player.tenThousandMoneyPlayer + "X R$10000,00 \n");
    }
    
    public void ConvertMoney(int convertMoney)
    {
        switch (convertMoney)
        {
            case 1:
                ConvertToHundred();
                break;
            case 2:
                ConvertToFiveHundred();
                break;
            case 3:
                ConvertToThousand();
                break;
            case 4:
                ConvertToFiveThousand();
                break;
            case 5:
                ConvertToTenThousand();
                break;
        }
        
    }
}
