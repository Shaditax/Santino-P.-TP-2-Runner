using UnityEngine;

public class Piso : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Awake()
    { 
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        float velocidad = GameManager.Instance.velocidadJuego / transform.localScale.x;
        meshRenderer.material.mainTextureOffset += Vector2.right * velocidad * Time.deltaTime;
    }
}
