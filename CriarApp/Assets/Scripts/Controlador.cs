using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{

    public void LoadScene(string LoadScene)
    {
        SceneManager.LoadScene("Tela2");
    }
}