using UnityEngine;

//script guarda la info del cubo
public class PuzzleCube : MonoBehaviour
{
    //ID de cubo
    public string cubeID;

    //prefab
    public GameObject cubePrefab;

    //posicion de spawn
    [HideInInspector]
    public Vector3 spawnPosition;

    void Start()
    {
        //guarda la posicion inicial
        spawnPosition = transform.position;
    }
}
