using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MansionDoor : MonoBehaviour
{
  [SerializeField] public DialogueCollider dialogueCollider;
  [SerializeField] public GameObject doorOpen;
  [SerializeField] public GameObject dialogueButton1;

  void Update()
  {
    if (Inventory.HasRustyKey == false && dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
    {
      dialogueButton1.SetActive(true);
    }
    else
    {
      dialogueButton1.SetActive(false);
    }
    if (Inventory.HasRustyKey == true && dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
    {
      doorOpen.SetActive(true);
    }
    else
    {
      doorOpen.SetActive(false);
    }
  }
}
