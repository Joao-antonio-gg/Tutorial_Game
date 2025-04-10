using UnityEngine;
using UnityEngine.SceneManagement;
public class Voltar : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }
}
