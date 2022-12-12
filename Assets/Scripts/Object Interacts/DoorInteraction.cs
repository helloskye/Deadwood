using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    [SerializeField] public DialogueCollider dialogueCollider;
    [SerializeField] public GameObject doorOpen;

    void Update()
    {
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        doorOpen.SetActive(true);
      }
      else
      {
        doorOpen.SetActive(false);
      }
    }
}
