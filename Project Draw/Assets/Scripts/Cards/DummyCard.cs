using UnityEngine;

public class DummyCard : Card
{
    public override void activateEffect()
    {
        Debug.Log("Dummy Card Played!");
    }
}
