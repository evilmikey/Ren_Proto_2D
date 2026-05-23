using UnityEngine;  
using System.Collections;
using UnityEngine.EventSystems;  
using UnityEngine.UI;

public class EasterEgg : MonoBehaviour
{
    private InventoryController inventoryController;

    private Item item;
    
    public AudioSource audioPlayer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inventoryController = FindFirstObjectByType<InventoryController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Surprise"))
        {
            audioPlayer.Play();
            Item item = collision.GetComponent<Item>();
            if (item != null)
            {
                //add item to inventory
                bool itemAdded = inventoryController.AddItem(item.Sprite);
                if (itemAdded)
                {
                    Destroy(collision.gameObject);
                }
            }
            
        }
        
    }
}
