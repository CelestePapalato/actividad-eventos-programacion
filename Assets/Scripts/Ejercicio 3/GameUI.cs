using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    private void UpdateCanvasVisibility(bool gameState)
    {
        canvas.enabled = gameState;
    }
    private void OnEnable()
    {
        GameStateManager.StateChanged += UpdateCanvasVisibility;
    }

    private void OnDestroy()
    {
        GameStateManager.StateChanged -= UpdateCanvasVisibility;
    }
}
