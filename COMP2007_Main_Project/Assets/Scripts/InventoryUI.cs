using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI collectedText;

    // Start is called before the first frame update
    void Start()
    {
        collectedText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCollectedText(PlayerInventory playerInventory)
    {
        collectedText.text = playerInventory.numberOfCollectables.ToString();
    }
}
