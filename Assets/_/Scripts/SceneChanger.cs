using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string selection_niveau1 = "selection_niveau1";

    public void ChangeLaScene()
    {
        Debug.Log("BOUTON CLIQUÉ !");
        Debug.Log("Scène demandée : " + selection_niveau1);

        SceneManager.LoadScene(selection_niveau1);
    }
}