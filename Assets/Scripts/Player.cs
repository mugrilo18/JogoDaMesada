using UnityEngine;

public class Player : MonoBehaviour
{
    Bank bank;

    public int hundredMoneyPlayer;
    public int fiveHundredMoneyPlayer;
    public int thousandMoneyPlayer;
    public int fiveThousandMoneyPlayer;
    public int tenThousandMoneyPlayer;
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
        thousandMoneyPlayer = 2;
        fiveHundredMoneyPlayer = 2;
        hundredMoneyPlayer = 5;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            bank.ConvertMoney();
        }
    }
}
