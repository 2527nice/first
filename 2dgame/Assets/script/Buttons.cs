using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainGame");
    }
}