using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicial : MonoBehaviour
{

    public void LoadScene(string LoadScene)
    {
        SceneManager.LoadScene("Tela1");
    }
}