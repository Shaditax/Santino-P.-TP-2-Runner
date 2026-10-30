using UnityEngine;

public class SpawnObstaculo : MonoBehaviour
{
    public GameObject[] arreglodeObjetos;
    public float delay;
    private float tiempoRepeticion;
    public Vector2 spawnPosition;


    void Start()
    {
        InvokeRepeating("SpawnMultiple", delay, tiempoRepeticion);
    }


    void SpawnMultiple()
    {
        tiempoRepeticion = Random.Range(2f, 4.5f);

        int indiceAleatorio = Random.Range(0, arreglodeObjetos.Length);
        GameObject obstaculosAleatorios = arreglodeObjetos[indiceAleatorio];
        Instantiate(obstaculosAleatorios, spawnPosition, Quaternion.identity);

        Invoke("SpawnMultiple", tiempoRepeticion);
    }
}