using UnityEngine;

public class Player : MonoBehaviour
{
    Bank bank;

    public int conversao;
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
        //bank.ConvertToHundred(fiveHundredMoneyPlayer, thousandMoneyPlayer, fiveThousandMoneyPlayer, tenThousandMoneyPlayer);
        //bank.ConvertToFiveHundred(hundredMoneyPlayer, fiveHundredMoneyPlayer, thousandMoneyPlayer, fiveThousandMoneyPlayer, tenThousandMoneyPlayer);
        //bank.ConvertToThousand(fiveThousandMoneyPlayer, tenThousandMoneyPlayer);
        //bank.ConvertToFiveThousand(tenThousandMoneyPlayer);

        //bank.TotalMoney(hundredMoneyPlayer, fiveHundredMoneyPlayer, thousandMoneyPlayer, fiveThousandMoneyPlayer, tenThousandMoneyPlayer);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (conversao == 0)
            {
                Debug.Log(hundredMoneyPlayer + "X R$100,00 \n" + fiveHundredMoneyPlayer + "X R$500,00 \n" + thousandMoneyPlayer + "X R$1000,00 \n" + fiveThousandMoneyPlayer + "X R$5000,00 \n" + tenThousandMoneyPlayer + "X R$10000,00 \n");
                bank.TotalMoney();
            }
            else
            {
                bank.ConvertMoney(conversao);
                bank.TotalMoney();
            }
        }
    }
}
