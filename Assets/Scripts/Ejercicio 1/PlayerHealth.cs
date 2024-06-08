using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int salud;

    public delegate void HealthUpdate(int health);
    public HealthUpdate PlayerHealthUpdate;

    private void Start()
    {
        PlayerHealthUpdate(salud);
    }

    public void Damage()
    {
        salud = Mathf.Max(0, salud - 1);
        PlayerHealthUpdate(salud);
    }
}
