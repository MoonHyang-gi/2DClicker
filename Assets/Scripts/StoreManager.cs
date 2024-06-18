using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    private ClickHandler clickHandler;

    [System.Serializable]
    public class Item
    {
        public string itemName;
        public int itemPrice;
        public Button itemButton;
    }

    public Item[] shopItems;

    void Start()
    {
        foreach (Item item in shopItems)
        {
            item.itemButton.onClick.AddListener(() => OnItemButtonClick(item));
        }
    }

    void OnItemButtonClick(Item item)
    {
        if (clickHandler.coin >= item.itemPrice)
        {
            clickHandler.coin -= item.itemPrice;
        }
    }
}
