using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{
    public static event Action<string> OnInteraction;

    [SerializeField] string dialogue;

    public void Interactuar()
    {
        OnInteraction?.Invoke(dialogue);
    }

    private void OnDestroy()
    {
        OnInteraction = null;
    }
}
