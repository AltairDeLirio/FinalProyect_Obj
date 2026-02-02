using System.Collections.Generic;
using UnityEngine;

//script para guardar los cubos en inventario
public class PlayerInventory : MonoBehaviour
{
    //lista de los cubos
    public List<PuzzleCube> cubes = new List<PuzzleCube>();

    //ref UI
    public InventoryUI inventoryUI;

    //añadir cubo al inventario
    public void AddCube(PuzzleCube cube)
    {
        cubes.Add(cube);

        //actualizar UI
        if (inventoryUI != null)
        {
            inventoryUI.UpdateUI();
        }
    }

    //queue de cubos
    public Queue<PuzzleCube> GetCubeQueue()
    {
        return new Queue<PuzzleCube>(cubes);
    }

    //vaciar inventario
    public void ClearInventory()
    {
        cubes.Clear();

        if (inventoryUI != null)
        {
            inventoryUI.UpdateUI();
        }
    }
}
