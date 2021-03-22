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
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
// credit: https://www.udemy.com/course/unitycourse2/learn/lecture/24879736?start=0#overview