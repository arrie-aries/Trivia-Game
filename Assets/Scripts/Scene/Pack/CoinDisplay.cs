using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _goldText;

    private void Update()
    {
        _goldText.text = Currency.currencyInstance.Coin.ToString() + "G";
    }
}
