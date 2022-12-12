using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bethany : MonoBehaviour
{
  [SerializeField] public DialogueCollider dialogueCollider;
  [SerializeField] public GameObject dialogueButton1;
  [SerializeField] public GameObject dialogueButton2;
  [SerializeField] public GameObject dialogueButton3;

  void Update()
  {
    if (Inventory.HasBracelet == false)
    {
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        dialogueButton1.SetActive(true);
      }
      else
      {
        dialogueButton1.SetActive(false);
      }
    }

    if (Inventory.HasBracelet == true)
    {
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        dialogueButton2.SetActive(true);
        QuestLog.TalkedToBethany = true;
      }
      else
      {
        dialogueButton2.SetActive(false);
      }
    }

    if (QuestLog.PostGame == true)
    {
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        dialogueButton3.SetActive(true);
      }
      else
      {
        dialogueButton3.SetActive(false);
      }
    }
  }
}
