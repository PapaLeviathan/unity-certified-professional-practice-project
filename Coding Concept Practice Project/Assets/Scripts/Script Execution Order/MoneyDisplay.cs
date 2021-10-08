using TMPro;
using UnityEngine;

public class MoneyDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _moneyText;

    private static MoneyDisplay instance;

    private void Awake()
    {
        instance = this;
    }
    public static void SetMoneyString(string moneyString)
    {
        instance._moneyText.text = moneyString;
    }
    
}