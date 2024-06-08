using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameStateManager : MonoBehaviour
{
    public static event Action<bool> StateChanged;

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Escape)) { return; }
        if (Time.deltaTime == 0)
        {
            Time.timeScale = 1;
            StateChanged?.Invoke(true);
        }
        else
        {
            Time.timeScale = 0;
            StateChanged?.Invoke(false);
        }
    }
}
