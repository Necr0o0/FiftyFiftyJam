﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameController : MonoBehaviour
{

    public void GotoMainScene()
    {
        SceneManager.LoadScene(1);
    }
}
