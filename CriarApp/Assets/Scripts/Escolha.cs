using UnityEngine;
using UnityEngine.SceneManagement;

public class Escolha : MonoBehaviour
{

    public void LoadScene(string LoadScene)
    {
        SceneManager.LoadScene("Tela3");
    }
}