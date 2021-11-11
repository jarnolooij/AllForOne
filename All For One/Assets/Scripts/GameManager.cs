using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public Player []players;
    private int currentPlayer;
    public bool startRounds;


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
        startRounds = false;
    }
    void StartRounds()
    {
        startRounds = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (startRounds == true)
        {
           
        }
    }

    void NextButtonClicked()
    {
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
