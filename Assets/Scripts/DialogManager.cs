using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogText; // UI Text to display the dialog
    [SerializeField] private Queue<string> sentences; // Queue to hold the sentences of the current dialog

    public void StartDialog(Dialog dialog)
    {
        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogText.text = sentence;
    }

    void EndDialog()
    {
        Debug.Log("End of dialog.");
        // You can add additional logic here to handle the end of a dialog, such as triggering a response
    }
}
