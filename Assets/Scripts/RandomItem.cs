using UnityEngine;

public class Array : MonoBehaviour
{
    [SerializeField]
    private string[] itemNames = new string[10];

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            PrintRandomItem();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PrintAllItems();
        }
    }

    void PrintRandomItem()
    {
        int randomIndex = Random.Range(0, 10);
        Debug.Log(itemNames[randomIndex]);
    }

    void PrintAllItems()
    {
        for(int i = 0; i < itemNames.Length; i++)
        {
            Debug.Log(itemNames[i]);
        }
    }
}
