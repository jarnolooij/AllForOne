using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject InsertPlayerNames;
    public GameObject inputField1;
    public GameObject inputField2;

    string username1;
    string username2;

    public void setValuePlayerName1()
    {
        username1 = inputField1.GetComponent<TMP_InputField>().text;
        GameManager.instance.player1 = new Player(username1);
    }
    public void setValuePlayerName2()
    {
        username2 = inputField2.GetComponent<TMP_InputField>().text;
        GameManager.instance.player2 = new Player(username2);
    }

    private void Start()
    {
        MainMenu.SetActive(true);
        InsertPlayerNames.SetActive(false);
    }

    public void StartGame()
    {
        MainMenu.SetActive(false);
        InsertPlayerNames.SetActive(true);
    }

    public void PlayGame()
    {
        setValuePlayerName1();
        setValuePlayerName2();
        SceneManager.LoadScene("PlayGround");
    }
    public void Back()
    {
        MainMenu.SetActive(true);
        InsertPlayerNames.SetActive(false);
    }


}
