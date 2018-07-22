using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDealer : MonoBehaviour
{
    public CardStack dealer;
    public CardStack player;

    // Debug test code to provide known cards
    //int count = 0;
    //int[] CardStack = new int[] { 9, 7, 12 };

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 256, 28), "Hit Me!"))
        {
            player.Push(dealer.Pop());
        }
        //if (GUI.Button(new Rect(10, 10, 256, 28), "Hit Me!"))
        //{
        //    player.Push(CardStack[count++]);
        //}
    }
}
