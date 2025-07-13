using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    Player player;
    private int hundredMoney;
    private int fiveHundredMoney;
    private int thousandMoney;
    private int fiveThousandMoney;
    private int tenThousandMoney;

    public enum QuantityConvert
    {
        // Convert to R$100,00
        FiveHundredToHundred,
        ThousandToHundred,
        FiveThousandToHundred,
        TenThousandToHundred,

        // Convert to R$500,00
        HundredToFiveHundred,
        ThousandToFiveHundred,
        FiveThousandToFiveHundred,
        TenThousandToFiveHundred,

        // Convert to R$1000,00
        HundredToThousand,
        FiveHundredToThousand,
        FiveThousandToThousand,
        TenThousandToThousand,

        // Convert to R$5000,00
        HundredToFiveThousand,
        FiveHundredToFiveThousand,
        ThousandToFiveThousand,
        TenThousandToFiveThousand,

        // Convert to R$10000,00
        HundredToTenThousand,
        FiveHundredToTenThousand,
        ThousandToTenThousand,
        FiveThousandToTenThousand,

    }

    [SerializeField] private QuantityConvert quantityConvert;

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

        return totalMoney.ToString();
    }

    public void ConvertMoney()
    {
        switch (quantityConvert)
        {
            // Convert to R$100,00
            case QuantityConvert.FiveHundredToHundred:
                if (player.fiveHundredMoneyPlayer >= 1)
                {
                    player.fiveHundredMoneyPlayer -= 1;
                    player.hundredMoneyPlayer += 5;
                }
                break;
            case QuantityConvert.ThousandToHundred:
                if (player.thousandMoneyPlayer >= 1)
                {
                    player.thousandMoneyPlayer -= 1;
                    player.hundredMoneyPlayer += 10;
                }
                break;
            case QuantityConvert.FiveThousandToHundred:
                if (player.fiveThousandMoneyPlayer >= 1)
                {
                    player.fiveThousandMoneyPlayer -= 1;
                    player.hundredMoneyPlayer += 50;
                }
                break;
            case QuantityConvert.TenThousandToHundred:
                if (player.tenThousandMoneyPlayer >= 1)
                {
                    player.tenThousandMoneyPlayer -= 1;
                    player.hundredMoneyPlayer += 100;
                }
                break;

            //Convert to R$500,00
            case QuantityConvert.HundredToFiveHundred:
                if (player.hundredMoneyPlayer >= 5)
                {
                    player.hundredMoneyPlayer -= 5;
                    player.fiveHundredMoneyPlayer++;
                }
                break;
            case QuantityConvert.ThousandToFiveHundred:
                if (player.thousandMoneyPlayer >= 1)
                {
                    player.thousandMoneyPlayer -= 1;
                    player.fiveHundredMoneyPlayer += 2;
                }
                break;
            case QuantityConvert.FiveThousandToFiveHundred:
                if (player.fiveThousandMoneyPlayer >= 1)
                {
                    player.fiveThousandMoneyPlayer -= 1;
                    player.fiveHundredMoneyPlayer += 10;
                }
                break;
            case QuantityConvert.TenThousandToFiveHundred:
                if (player.tenThousandMoneyPlayer >= 1)
                {
                    player.tenThousandMoneyPlayer -= 1;
                    player.fiveHundredMoneyPlayer += 20;
                }
                break;

            // Convert to R$1000,00
            case QuantityConvert.HundredToThousand:
                if (player.hundredMoneyPlayer >= 10)
                {
                    player.hundredMoneyPlayer -= 10;
                    player.thousandMoneyPlayer++;
                }
                break;
            case QuantityConvert.FiveHundredToThousand:
                if (player.fiveHundredMoneyPlayer >= 2)
                {
                    player.fiveHundredMoneyPlayer -= 2;
                    player.thousandMoneyPlayer++;
                }
                break;
            case QuantityConvert.FiveThousandToThousand:
                if (player.fiveThousandMoneyPlayer >= 1)
                {
                    player.fiveThousandMoneyPlayer -= 1;
                    player.thousandMoneyPlayer += 5;
                }
                break;
            case QuantityConvert.TenThousandToThousand:
                if (player.tenThousandMoneyPlayer >= 1)
                {
                    player.tenThousandMoneyPlayer -= 1;
                    player.thousandMoneyPlayer += 10;
                }
                break;
            // Convert to R$5000,00
            case QuantityConvert.HundredToFiveThousand:
                if (player.hundredMoneyPlayer >= 50)
                {
                    player.hundredMoneyPlayer -= 50;
                    player.fiveThousandMoneyPlayer++;
                }
                break;
            case QuantityConvert.FiveHundredToFiveThousand:
                if (player.fiveHundredMoneyPlayer >= 10)
                {
                    player.fiveHundredMoneyPlayer -= 10;
                    player.fiveThousandMoneyPlayer++;
                }
                break;
            case QuantityConvert.ThousandToFiveThousand:
                if (player.thousandMoneyPlayer >= 5)
                {
                    player.thousandMoneyPlayer -= 5;
                    player.fiveThousandMoneyPlayer++;
                }
                break;
            case QuantityConvert.TenThousandToFiveThousand:
                if (player.tenThousandMoneyPlayer >= 1)
                {
                    player.tenThousandMoneyPlayer -= 1;
                    player.fiveThousandMoneyPlayer += 2;
                }
                break;
            // Convert to R$10000,00
            case QuantityConvert.HundredToTenThousand:
                if (player.hundredMoneyPlayer >= 100)
                {
                    player.hundredMoneyPlayer -= 100;
                    player.tenThousandMoneyPlayer++;
                }
                break;
            case QuantityConvert.FiveHundredToTenThousand:
                if (player.fiveHundredMoneyPlayer >= 20)
                {
                    player.fiveHundredMoneyPlayer -= 20;
                    player.tenThousandMoneyPlayer++;
                }
                break;
            case QuantityConvert.ThousandToTenThousand:
                if (player.thousandMoneyPlayer >= 10)
                {
                    player.thousandMoneyPlayer -= 10;
                    player.tenThousandMoneyPlayer++;
                }
                break;
            case QuantityConvert.FiveThousandToTenThousand:
                if (player.fiveThousandMoneyPlayer >= 2)
                {
                    player.fiveThousandMoneyPlayer -= 2;
                    player.tenThousandMoneyPlayer++;
                }
                break;
        }

    }
}
