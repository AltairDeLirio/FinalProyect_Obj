using System.Collections.Generic;
using UnityEngine;

//script para la zona donde el jugador abre la puerta
public class PuzzleInputZone : MonoBehaviour
{
    //orden de los cubos correcto
    public List<string> correctOrder;

    //ref puerta
    public DoorController door;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        PlayerInventory inventory = other.GetComponent<PlayerInventory>();
        if (inventory == null) return;

        Queue<PuzzleCube> cubeQueue = inventory.GetCubeQueue();

        if (CheckOrder(cubeQueue))
        {
            //correcto abre la puerta
            if (door != null)
                door.OpenDoor();

            inventory.ClearInventory();
        }
        else
        {
            //si es incorrecto, reactiva los cubos
            foreach (PuzzleCube cube in inventory.cubes)
            {
                if (cube != null)
                    cube.gameObject.SetActive(true);
            }

            inventory.ClearInventory();
        }
    }

    private bool CheckOrder(Queue<PuzzleCube> queue)
    {
        if (queue.Count != correctOrder.Count)
            return false;

        foreach (string correct in correctOrder)
        {
            PuzzleCube cube = queue.Dequeue();
            if (cube.cubeID != correct)
                return false;
        }

        return true;
    }
}
