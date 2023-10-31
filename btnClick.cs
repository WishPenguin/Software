using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnClick : MonoBehaviour
{
    public void BtnNewScene()
    {
        SceneManager.LoadScene("MashUpMess");
    }
}
