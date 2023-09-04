using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public Card[] AllCards { get; private set; }
    private Card[] Hand;
    private Card[] Draw;
    private Card[] Discard;

    ///TODO: what are we looking for? Hand? Draw? all cards?
    public int cardCount => Hand.Length;

    public PlayerDeck(Card[] startingCards = null)
    {
        AllCards = startingCards ?? new Card[] {};
    }

}
