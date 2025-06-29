using UnityEngine;

public class Bank : MonoBehaviour
{
    Player player;
    private int hundredMoney;
    private int fiveHundredMoney;
    private int thousandMoney;
    private int fiveThousandMoney;
    private int tenThousandMoney;

    public void TotalMoney(int hMoney, int fHMoney, int tMoney, int fTMoney, int tTMoney)
    {
        int totalMoney;

        hundredMoney = hMoney * 100;
        fiveHundredMoney = fHMoney * 500;
        thousandMoney = tMoney * 1000;
        fiveThousandMoney = fTMoney * 5000;
        tenThousandMoney = tTMoney * 10000;

        totalMoney = hundredMoney + fiveHundredMoney + thousandMoney + fiveThousandMoney + tenThousandMoney;
        Debug.Log(totalMoney);
    }
}
