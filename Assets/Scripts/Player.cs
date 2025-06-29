using UnityEngine;

public class Player : MonoBehaviour
{
    Bank bank;

    private int hundredMoneyPlayer = 5;
    private int fiveHundredMoneyPlayer = 2;
    private int thousandMoneyPlayer = 2;
    private int fiveThousandMoneyPlayer;
    private int tenThousandMoneyPlayer;
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
        bank.TotalMoney(hundredMoneyPlayer, fiveHundredMoneyPlayer, thousandMoneyPlayer, fiveThousandMoneyPlayer, tenThousandMoneyPlayer);
    }




}
