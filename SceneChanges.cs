﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanges : MonoBehaviour
{
    public void Scene0() {  
        SceneManager.LoadScene("Scene0");  
    }
    public void Scene1() {
        SceneManager.LoadScene("Scene1");
    }  
}
