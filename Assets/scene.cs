using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //namespace ini kita gunakan agar dapat memanggil methods untuk berpindah scene yang ada pada class SceneManagement

public class scene : MonoBehaviour
{
    public void LoadToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}