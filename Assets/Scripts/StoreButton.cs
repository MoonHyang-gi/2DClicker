using UnityEngine;
using UnityEngine.UI;

public class StoreButton : MonoBehaviour
{
    public GameObject storePanel;
    public Button closeButton;

    public void Awake()
    {
        CloseStore();
        if (closeButton != null)
        {
            closeButton.onClick.AddListener(CloseStore);
        }
    }

    public void OpenStore()
    {
        storePanel.SetActive(true);
    }

    public void CloseStore()
    {
        storePanel.SetActive(false);
    }
}
