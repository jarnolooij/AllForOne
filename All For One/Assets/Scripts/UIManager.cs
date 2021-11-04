using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
   // public GameObject PlayerNameText;

    public GameObject ShopUI;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI moneyText;
    void PlayerName()
    {
        nameText.text = GameManager.instance.CurrentPlayer.PlayerName;
    }

    void PlayerMoney()
    {
       moneyText.text = GameManager.instance.CurrentPlayer.Money.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        ShopUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerName();
        PlayerMoney();
    }
}
