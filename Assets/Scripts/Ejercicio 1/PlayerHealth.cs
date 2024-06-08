using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int salud;

    public UnityEvent<int> PlayerHealthUpdate;

    private void Start()
    {
        PlayerHealthUpdate?.Invoke(salud);
    }

    public void Damage()
    {
        salud = Mathf.Max(0, salud - 1);
        PlayerHealthUpdate?.Invoke(salud);
    }
}
