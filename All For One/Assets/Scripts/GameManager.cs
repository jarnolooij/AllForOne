using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public Player []players;
    private int currentPlayer;
    public bool disableUI;


    public Player CurrentPlayer => players[currentPlayer];


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        players = new Player[2];
    }

    // Start is called before the first frame update
    void Start()
    {
        currentPlayer = 0;
        disableUI = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void NextButtonClicked()
    {
        //pick spawnpoint
        currentPlayer++;
    }

    void NextPlayer()
    {
        currentPlayer++;
        if(currentPlayer == players.Length)
        {
            currentPlayer = 0;
        }
    }
}
