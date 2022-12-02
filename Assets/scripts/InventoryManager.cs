using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Referenced from youtube tutorial by Solo Game Dev on how to create a inventory system (https://www.youtube.com/watch?v=AoD_F1fSFFg&t=504s)

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>(); 
    public Transform InventoryContent;
    public GameObject InventoryItem;
    private void Awake() {
        Instance = this;
    }

    public void Add(Item item){
        Items.Add(item);
    }

    public void list_items(){

        foreach (Transform item in InventoryContent){
            Destroy(item.gameObject);
        }

        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, InventoryContent);
            var itemname = obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
            var itemicon = obj.transform.Find("Icon").GetComponent<Image>();
            itemname.text = item.Var;
            itemicon.sprite = item.Icon;
        }
    }
}
