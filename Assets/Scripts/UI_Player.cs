using TMPro;
using UnityEngine;

public class UI_Player : MonoBehaviour
{
    Player player;
    Bank bank;

    [SerializeField] private GameObject hundred;
    [SerializeField] private GameObject fiveHundred;
    [SerializeField] private GameObject thousand;
    [SerializeField] private GameObject fiveThousand;
    [SerializeField] private GameObject tenThousand;
    [SerializeField] private GameObject totalMoney;

    TextMeshProUGUI hundredText;
    TextMeshProUGUI fiveHundredText;
    TextMeshProUGUI thousandText;
    TextMeshProUGUI fiveThousandText;
    TextMeshProUGUI tenThousandText;
    TextMeshProUGUI totalMoneyText;

    private void Awake()
    {
        player = GetComponent<Player>();
        bank = GetComponent<Bank>();
    }

    void Start()
    {
        hundredText = hundred.GetComponent<TextMeshProUGUI>();
        fiveHundredText = fiveHundred.GetComponent<TextMeshProUGUI>();
        thousandText = thousand.GetComponent<TextMeshProUGUI>();
        fiveThousandText = fiveThousand.GetComponent<TextMeshProUGUI>();
        tenThousandText = tenThousand.GetComponent<TextMeshProUGUI>();
        totalMoneyText = totalMoney.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        hundredText.text = (player.hundredMoneyPlayer.ToString() + "X");
        fiveHundredText.text = (player.fiveHundredMoneyPlayer.ToString() + "X");
        thousandText.text = (player.thousandMoneyPlayer.ToString() + "X");
        fiveThousandText.text = (player.fiveThousandMoneyPlayer.ToString() + "X");
        tenThousandText.text = (player.tenThousandMoneyPlayer.ToString() + "X");
        totalMoneyText.text = ("R$" + bank.TotalMoney() + ",00");
    }
}
