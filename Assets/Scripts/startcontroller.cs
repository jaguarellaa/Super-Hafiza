using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startcontroller : MonoBehaviour
{
    
    public void fonkstart()
    {
       
        SceneManager.LoadScene(1);
    }

    public void deletedata()
    {
        PlayerPrefs.DeleteAll();
    }
}
