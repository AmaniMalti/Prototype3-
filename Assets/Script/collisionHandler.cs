using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
       switch (other.gameObject.tag)
        {
            case "Friendly":
                break;
            case "Finish":
                break;
            case "Fuel":
                break;
            default:
                ReloadLevel();
                break;
        }
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
