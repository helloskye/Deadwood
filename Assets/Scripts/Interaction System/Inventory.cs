using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    //Inventory variables.
    public static bool HasAxe = false; //To cut through bramble blocking the pathway from town to woods.
    public static bool HasBracelet = false; //To get Santiana to open up to Detective.
    public static bool HasWitheredFlower = false; //When Brought to the bartender she will make you a drink to restore your memory
    public static bool HasRustyKey = false; //Unlocks the abandon mansion

    public static bool HasBadge = false; //From Cat. Connects Detective to Marilou, his daughter.
    //public static bool HasBadgeHalf2 = false; //From Graveyard. Connects Detective to Marilou, his daughter.

    private void Update()
    {

    }
}
