using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MasterInfo : MonoBehaviour
{
    public static int coinCount = 0;
    [SerializeField] GameObject coinDisplay;

    void Update()
    {
        coinDisplay.GetComponent<TextMeshProUGUI>().text = "COINS: " + coinCount.ToString();
    }
}
