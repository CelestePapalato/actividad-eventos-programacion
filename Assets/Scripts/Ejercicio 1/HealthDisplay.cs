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
        if (health)
        {
            health.PlayerHealthUpdate.AddListener(UpdateText);
        }
        healthText = GetComponent<Text>();
    }

    private void UpdateText(int value)
    {
        healthText.text = value.ToString();
    }
}
