using UnityEngine;

public class Player : MonoBehaviour
{
    Bank bank;

    [SerializeField] private int hundredMoneyPlayer = 5;
    [SerializeField] private int fiveHundredMoneyPlayer = 1;
    [SerializeField] private int thousandMoneyPlayer = 2;
    [SerializeField] private int fiveThousandMoneyPlayer;
    [SerializeField] private int tenThousandMoneyPlayer;
    /*     [SerializeField] private int colorPawn;
        [SerializeField] private int investment;
        [SerializeField] private int monsterCharge;
        [SerializeField] private int loan; */

    private void Awake()
    {
        bank = GetComponent<Bank>();
    }
    private void Start()
    {
        Debug.Log(hundredMoneyPlayer + "X R$100,00 \n" + fiveHundredMoneyPlayer + "X R$500,00 \n" + thousandMoneyPlayer + "X R$1000,00 \n" + fiveThousandMoneyPlayer + "X R$5000,00 \n" + tenThousandMoneyPlayer + "X R$10000,00 \n");
        bank.TotalMoney(hundredMoneyPlayer, fiveHundredMoneyPlayer, thousandMoneyPlayer, fiveThousandMoneyPlayer, tenThousandMoneyPlayer);
        bank.ConvertToHundred(fiveHundredMoneyPlayer, thousandMoneyPlayer, fiveThousandMoneyPlayer, tenThousandMoneyPlayer);
    }




}
