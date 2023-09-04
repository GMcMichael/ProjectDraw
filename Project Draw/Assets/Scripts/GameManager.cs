using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public enum PhaseStates
    {
        DrawToFive,
        PlaySpells,
        Buy,
        Discard
    }
    private Player[] players;
    public int playerCount { get { return players.Length; } private set { } }

    public int turnCounter { get; private set; }
    public int playerTurn { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(gameObject);
        else Instance = this;
    }
    private void Start()
    {
        ///TODO: Here is where all the game logic will be set up. This is called on the first frame
    }

    private void Update()
    {
        ///TODO: Here is where the game loop will be, this is called every frame
    }

    public void changeTurns()
    {
        turnCounter++;
        playerTurn++;
        playerTurn %= playerCount;
    }

    public bool checkGameEnd()
    {
        return turnCounter >= 10;
    }
}
