using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string selection_niveau1 = "selection_niveau";

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(selection_niveau1);
    }
}