using UnityEngine;

public class Piso2 : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Vector2 spawnPosition;
    public float delay = 2f;
    public float tiempoRepeticion = 2f;

    void Start()
    {
        InvokeRepeating("CrearObstaculo", delay, tiempoRepeticion);
    }


    void CrearObstaculo()
    {
        Instantiate(spawnPrefab, spawnPosition, Quaternion.identity);
    }
}
