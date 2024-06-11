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
        healthText = GetComponent<Text>();
    }

    private void OnEnable()
    {
        if (health)
        {
            health.PlayerHealthUpdate.AddListener(UpdateText);
        }
    }

    private void OnDisable()
    {
        if (health)
        {
            health.PlayerHealthUpdate.RemoveListener(UpdateText);
        }
    }

    private void UpdateText(int value)
    {
        healthText.text = value.ToString();
    }
}
