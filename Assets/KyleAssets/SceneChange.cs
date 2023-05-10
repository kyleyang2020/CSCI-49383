using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void EricScene()
    {
        SceneManager.LoadScene("Eric");
    }

    public void FarhanaScene()
    {
        SceneManager.LoadScene("Farhana");
    }
    public void KyleScene()
    {
        SceneManager.LoadScene("Kyle");
    }

    public void HomeScene()
    {
        SceneManager.LoadScene("Sample");
    }
}