using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MovimientoPlayer : MonoBehaviour
{

    private Rigidbody2D rb;
    private bool tocarPiso;
    [Range(0f, 8f)] public float fuerzaSalto = 8f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && tocarPiso == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.y, fuerzaSalto);
            tocarPiso = false;
        }
   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            tocarPiso = true;
        }

        if (collision.collider.CompareTag("Obstaculo"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}


