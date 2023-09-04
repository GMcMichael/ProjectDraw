using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
    public int ID { get; private set; }
    public int cost { get; private set; }

    public abstract void activateEffect();
}

public abstract class ScoreCard : Card
{
    public int score { get; private set; }
}

public abstract class SpellCard : Card
{
    public int energyCost { get; private set; }
}

public abstract class TreasureCard : Card
{
    public int treasureAmount { get; private set; }
}
