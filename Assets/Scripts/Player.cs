using UnityEngine;

public class Player : MonoBehaviour
{
    private int hundredMoney = 5;
    private int fiveHundredMoney = 2;
    private int thousandMoney = 2;
    private int fiveThousandMoney;
    private int tenThousandMoney;
/*     [SerializeField] private int colorPawn;
    [SerializeField] private int investment;
    [SerializeField] private int monsterCharge;
    [SerializeField] private int loan; */

    void Start()
    {
        TotalMoney(hundredMoney, fiveHundredMoney, thousandMoney, fiveThousandMoney, tenThousandMoney);
    }

    private void TotalMoney(int hMoney, int fHMoney, int tMoney, int fTMoney, int tTMoney)
    {
        int totalMoney;

        hMoney = hundredMoney * 100;
        fHMoney = fiveHundredMoney * 500;
        tMoney = thousandMoney * 1000;
        fTMoney = fiveThousandMoney * 5000;
        tTMoney = tenThousandMoney * 10000;

        totalMoney = hMoney + fHMoney + tMoney + fTMoney + tTMoney;
        Debug.Log(totalMoney);
    }


}
