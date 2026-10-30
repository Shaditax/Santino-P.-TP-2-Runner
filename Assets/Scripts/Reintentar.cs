using UnityEngine;
using UnityEngine.SceneManagement;

public class Reintentar : MonoBehaviour
{
    public void Rejugar()
    {
        SceneManager.LoadScene("GameScene");
    }
}
