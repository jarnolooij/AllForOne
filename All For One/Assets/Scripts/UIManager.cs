using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
   // public GameObject PlayerNameText;

    public TextMeshProUGUI NameText;
    void PlayerName()
    {
        NameText.text = GameManager.instance.player1.PlayerName;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerName();
    }
}
