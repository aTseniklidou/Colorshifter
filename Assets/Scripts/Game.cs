using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

[System.Serializable]
public class Game
{

    public static Game current;
    public static int level = 1;

    public static void LoadNextLevel()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        int level = Convert.ToInt32(currentScene.name.Substring(5)) + 1;
        Game.level = level;
        SceneManager.LoadScene("Level" + level, LoadSceneMode.Single);
        SaveLoad.Save();
    }

}
