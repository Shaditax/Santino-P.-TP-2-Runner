using UnityEngine;
using UnityEngine.Rendering;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public float velocidadJuego {  get; private set; }
    public float velocidadJuegoInicial = 5f;
    public float velocidadJuegoIncremental = 0.1f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
              Instance = null;
        }
    }

    private void Start()
    {
        juegoNuevo();  
    }

    private void juegoNuevo()
    {
        velocidadJuego = velocidadJuegoInicial;
    }

    private void Update()
    {
        velocidadJuego = velocidadJuegoIncremental * Time.deltaTime;
    }
}
