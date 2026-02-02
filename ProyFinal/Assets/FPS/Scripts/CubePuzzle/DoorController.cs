using UnityEngine;

//script para la puerta
public class DoorController : MonoBehaviour
{
    //si el puzzle se soluciona correctamente
    public void OpenDoor()
    {
        //desactivar la puerta para que el jugador pueda pasar
        gameObject.SetActive(false);
    }
}
