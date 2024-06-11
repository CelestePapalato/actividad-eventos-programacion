using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelDisplay : MonoBehaviour
{
    Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    private void OnEnable()
    {
        LevelManager.OnLevelChange += UpdateLevelName;
    }

    private void OnDisable()
    {
        LevelManager.OnLevelChange -= UpdateLevelName;
    }

    private void UpdateLevelName(string name)
    {
        text.text = name;
    }
}
