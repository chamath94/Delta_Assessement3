using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nav_controller_Hiru : MonoBehaviour
{

    public void LoadScene(string HirushkaScene)
    {
        SceneManager.LoadScene(HirushkaScene);
    }
}

