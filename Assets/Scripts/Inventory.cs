using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemInventory = new List<GameObject>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReplaceItem();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            itemInventory.Add(other.gameObject);
            other.gameObject.SetActive(false);
        }
    }

    void ReplaceItem()
    {
        if (itemInventory.Count > 0)
        {
            GameObject lastItem = itemInventory[itemInventory.Count - 1];

            // Plaats item naast de speler
            lastItem.transform.position = transform.position + transform.forward * 1.5f;

            lastItem.SetActive(true);
            itemInventory.RemoveAt(itemInventory.Count - 1);
        }
    }
}
