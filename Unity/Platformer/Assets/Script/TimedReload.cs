using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedReload : MonoBehaviour
{
    [SerializeField] float time = 1;

    public void Invoke()
    {
        Invoke("Reload", time);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
