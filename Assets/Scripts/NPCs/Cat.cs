using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
  [SerializeField] public DialogueCollider dialogueCollider;
  [SerializeField] public GameObject dialogueButton1;
  [SerializeField] public GameObject dialogueButton2;
  [SerializeField] public GameObject badge;

  void Update()
  {
    if (QuestLog.TalkedToBethany == false)
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

    if (QuestLog.TalkedToBethany == true)
    {
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        QuestLog.TalkedToCat = true;
        dialogueButton2.SetActive(true);
        if (Inventory.HasBadge == false)
        {
          badge.SetActive(true);
        }
      }
      else
      {
        dialogueButton2.SetActive(false);
      }
    }
  }
}
