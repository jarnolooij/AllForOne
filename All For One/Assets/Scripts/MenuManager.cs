using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject InsertPlayerNames;
    public GameObject inputField1;
    public GameObject inputField2;
    string username1;
    string username2;
    public void getValuePlayerName1()
    {
        username1 = inputField1.GetComponent<TMP_InputField>().text;
    }
    public void getValuePlayerName2()
    {
        username2 = inputField2.GetComponent<TMP_InputField>().text;
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
        Debug.Log(username1);
        Debug.Log(username2);
        SceneManager.LoadScene("PlayGround");
    }
    public void Back()
    {
        MainMenu.SetActive(true);
        InsertPlayerNames.SetActive(false);
    }


}
