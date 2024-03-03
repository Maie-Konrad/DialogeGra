using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerSystem : MonoBehaviour
{

    DialogueList dialogu;



    public void TriggerDialogue()
    {
       
        FindObjectOfType<DialogueManagerSystem>().StartDialog(dialogu.dialogue); 
    }


}
