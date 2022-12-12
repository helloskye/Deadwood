using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Badge : MonoBehaviour
{
  [SerializeField] public DialogueCollider dialogueCollider;
  [SerializeField] public GameObject dialogueButton1;
  [SerializeField] public GameObject badge;

  void Update()
  {
    if (DialogueManager.dialogueIsOpen == true && Inventory.HasBadge == true)
    {
      badge.SetActive(false);
    }
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        dialogueButton1.SetActive(true);
        Inventory.HasBadge = true;
      }
      else
      {
        dialogueButton1.SetActive(false);
      }
  }
}
