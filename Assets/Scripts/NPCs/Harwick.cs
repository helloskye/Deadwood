using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harwick : MonoBehaviour
{
  [SerializeField] public DialogueCollider dialogueCollider;
  [SerializeField] public GameObject dialogueButton1;

  void Update()
  {
    if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
    {
      Inventory.HasRustyKey = true;
      dialogueButton1.SetActive(true);
    }
    else
    {
      dialogueButton1.SetActive(false);
    }
  }
}
