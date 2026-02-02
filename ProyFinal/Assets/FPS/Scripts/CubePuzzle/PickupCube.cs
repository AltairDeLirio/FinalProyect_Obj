using UnityEngine;

//script para recoger el cubo
public class PickupCube : MonoBehaviour
{
    private PuzzleCube cube; // Referencia al PuzzleCube

    void Awake()
    {
        cube = GetComponent<PuzzleCube>();
    }

    void OnTriggerEnter(Collider other)
    {
        //asegurarse que es el jugador
        if (!other.CompareTag("Player")) return;

        //obtener el inventario del jugador
        PlayerInventory inventory = other.GetComponent<PlayerInventory>();
        if (inventory == null) return;

        //añadir el cubo al inventario
        inventory.AddCube(cube);

        //deactivar cubo
        cube.gameObject.SetActive(false);
    }
}
