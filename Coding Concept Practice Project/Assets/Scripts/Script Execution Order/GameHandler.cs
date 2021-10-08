using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private void Awake()
    {
        string moneyString = "Money: $100";
        MoneyDisplay.SetMoneyString(moneyString);
    }
}