using UnityEngine.SceneManagement;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void Q()
    {
        Application.Quit();
    }
}


