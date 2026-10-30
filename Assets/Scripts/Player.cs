using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private CharacterController character;
    private Vector3 direccion;

    public float gravedad = 9.81f * 2f;
    public float fuerzaSalto = 8f;

    private void Awake()
    {
        character = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        direccion = Vector3.zero;
    }

    private void Update()
    {
        direccion += Vector3.down * gravedad * Time.deltaTime;

        if (character.isGrounded)
        {
            direccion = Vector3.down;

            if (Input.GetButton("Jump"))
            {
                direccion = Vector3.up * fuerzaSalto;
            }
        }

        character.Move(direccion * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstaculo"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
