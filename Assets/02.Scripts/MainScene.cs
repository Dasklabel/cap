using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    public void Button()
    {
        SceneManager.LoadScene("CharacterMove");
    }

}
