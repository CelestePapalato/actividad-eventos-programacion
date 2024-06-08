using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] PlayerHealth health;

    Text healthText;

    private void Awake()
    {
        if(!health) {  return; }
        health.PlayerHealthUpdate += UpdateText;
        healthText = GetComponent<Text>();
    }

    private void UpdateText(int value)
    {
        if (!healthText) {  return; }
        healthText.text = value.ToString();
    }
}
