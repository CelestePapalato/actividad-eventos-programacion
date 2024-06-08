using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptables/Item", order = 0)]
public class Item : ScriptableObject
{
    [SerializeField]
    private string nombre;
    public string Nombre { get => nombre; private set => nombre = value; }
}

public class Collectible : MonoBehaviour
{
    [SerializeField] Item itemData;

    public UnityEvent<Item> OnCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnCollected?.Invoke(itemData);
        Destroy(gameObject);
    }
}
