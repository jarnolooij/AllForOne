using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
   // public GameObject PlayerNameText;

    public GameObject ShopUI;
    public string currentPlayerMoney;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI moneyText;

    public TextMeshProUGUI healthText;
    public TextMeshProUGUI strenghtText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI defenceText;
    public Slider healthSlider;
    public Slider strenghtSlider;
    public Slider speedSlider;
    public Slider defenceSlider;
    //UI
    void PlayerName()
    {
        nameText.text = GameManager.instance.CurrentPlayer.PlayerName;
    }

    void PlayerMoney()
    {
        moneyText.text = GameManager.instance.CurrentPlayer.Money.ToString();
        //moneyText.text = currentPlayerMoney;
    }
    void subtractBalance()
    {
        //currentPlayerMoney = GameManager.instance.CurrentPlayer.Money -= healthSlider.value;
    }

    //sliders UI
    void ResetSliders()
    {
        healthSlider.maxValue = 90.0f;
        healthSlider.minValue = 0f;

        strenghtSlider.maxValue = 90.0f;
        strenghtSlider.minValue = 0f;

        speedSlider.maxValue = 90.0f;
        speedSlider.minValue = 0f;

        defenceSlider.maxValue = 90.0f;
        defenceSlider.minValue = 0f;
    }
    void HealthSlider()
    {
        healthText.text = healthSlider.value.ToString();
        
    }
    void StrenghtSlider()
    {
        strenghtText.text = strenghtSlider.value.ToString();
    }
    void SpeedSlider()
    {
        speedText.text = speedSlider.value.ToString();
    }
    void DefenceSlider()
    {
        defenceText.text = defenceSlider.value.ToString();
    }


    // Start is called before the first frame update
    void Start()
    {
        ShopUI.SetActive(true);
        ResetSliders();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerName();
        PlayerMoney();
        HealthSlider();
        SpeedSlider();
        StrenghtSlider();
        DefenceSlider();
        subtractBalance();
    }
}
