using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<Item> inventory = new List<Item>();

    public void AddItem(Item item)
    {
        inventory.Add(item);
        Debug.Log("Añadido objeto " + item.Nombre + ". Pulsa I para ver tu inventario.");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            foreach (Item item in inventory)
            {
                Debug.Log(item.Nombre);
            }
        }
    }
}
