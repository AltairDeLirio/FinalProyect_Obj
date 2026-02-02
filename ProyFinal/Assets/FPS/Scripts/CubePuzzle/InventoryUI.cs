using TMPro;
using UnityEngine;

//mostrar inventario en UI
public class InventoryUI : MonoBehaviour
{
    public TextMeshProUGUI inventoryText;
    public PlayerInventory playerInventory;

    void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (inventoryText == null || playerInventory == null) return;

        inventoryText.text = "Inventory:\n";

        if (playerInventory.cubes.Count == 0)
        {
            inventoryText.text += "(Empty)";
            return;
        }

        for (int i = 0; i < playerInventory.cubes.Count; i++)
        {
            inventoryText.text += $"{i + 1}. {playerInventory.cubes[i].cubeID}\n";
        }
    }
}
