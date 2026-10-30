using UnityEngine;

public class MovimientoObstaculo : MonoBehaviour
{
    public float velocidad = 3f;
    public float tiempoInicial = 0f;

    public float tiempoDeVidaMaximo = 5f;

    void Update()
    {
        transform.position -= new Vector3(velocidad * Time.deltaTime, 0, 0);

        tiempoInicial += Time.deltaTime;

        if (tiempoInicial >= tiempoDeVidaMaximo)
        {
            Destroy(this.gameObject);
        }
    }

}
