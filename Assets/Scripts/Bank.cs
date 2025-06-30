using UnityEngine;

public class Bank : MonoBehaviour
{
    Player player;
    private int hundredMoney;
    private int fiveHundredMoney;
    private int thousandMoney;
    private int fiveThousandMoney;
    private int tenThousandMoney;

    public void TotalMoney(int hundredMoneyPlayer, int fiveHundredMoneyPlayer, int thousandMoneyPlayer, int fiveThousandMoneyPlayer, int tenThousandMoneyPlayer)
    {
        int totalMoney;

        hundredMoney = hundredMoneyPlayer * 100;
        fiveHundredMoney = fiveHundredMoneyPlayer * 500;
        thousandMoney = thousandMoneyPlayer * 1000;
        fiveThousandMoney = fiveThousandMoneyPlayer * 5000;
        tenThousandMoney = tenThousandMoneyPlayer * 10000;

        totalMoney = hundredMoney + fiveHundredMoney + thousandMoney + fiveThousandMoney + tenThousandMoney;
        Debug.Log("Dinheiro total: R$" + totalMoney + ",00");
    }

    public void ConvertToHundred(int fiveHundredMoneyPlayer, int thousandMoneyPlayer, int fiveThousandMoneyPlayer, int tenThousandMoneyPlayer)
    {
        fiveHundredMoneyPlayer = fiveHundredMoney / 100;
        thousandMoneyPlayer = thousandMoney / 100;
        fiveThousandMoneyPlayer = fiveThousandMoney / 100;
        tenThousandMoneyPlayer = tenThousandMoney / 100;

        Debug.Log(fiveHundredMoneyPlayer + "X R$100,00 \n" + thousandMoneyPlayer + "X R$100,00 \n" + fiveThousandMoneyPlayer + "X R$100,00 \n" + tenThousandMoneyPlayer + "X R$100,00 \n");

    }
}
