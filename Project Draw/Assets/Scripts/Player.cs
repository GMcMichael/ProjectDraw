using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager.PhaseStates phase { get; private set; } = GameManager.PhaseStates.DrawToFive;
    public int treasure { get; private set; }
    public int score { get; private set; }
    public PlayerDeck deck;

    private void EndTurn() { GameManager.Instance.changeTurns(); }

    private void playSpell(Card card)
    {
        Debug.Log(card.GetType());
        if (card.GetType() != typeof(SpellCard)) return;
    }

    private void playTreasure(Card card)
    {
        if (card.GetType() != typeof(TreasureCard)) return;
    }
}
