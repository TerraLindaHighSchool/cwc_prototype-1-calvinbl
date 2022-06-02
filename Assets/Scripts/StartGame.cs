using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string CarGame;

    public void LoadLevel1()
    {
        SceneManager.LoadScene(CarGame);
    }

}