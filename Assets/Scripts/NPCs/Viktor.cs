using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viktor : MonoBehaviour
{
  [SerializeField] public DialogueCollider dialogueCollider;
  [SerializeField] public GameObject dialogueButton1;

  void Update()
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
}
