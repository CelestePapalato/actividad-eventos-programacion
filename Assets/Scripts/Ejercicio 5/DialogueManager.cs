using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] Text dialogueText;

    Canvas canvas;

    bool dialogueOn = false;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    private void OnEnable()
    {
        NPC.OnInteraction += ShowDialogue;
    }

    private void OnDisable()
    {
        NPC.OnInteraction -= ShowDialogue;
    }

    private void ShowDialogue(string dialogue)
    {
        dialogueText.text = dialogue;
        canvas.enabled = true;
        dialogueOn = true;
    }

    private void HideDialogue()
    {
        canvas.enabled = false;
        dialogueOn = false;
    }

    private void Update()
    {
        if(!dialogueOn) { return; }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            HideDialogue();
        }
    }
}
