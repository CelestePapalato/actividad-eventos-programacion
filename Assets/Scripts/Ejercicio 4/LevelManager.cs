using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static event Action<string> OnLevelChange;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += LevelLoaded; 
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= LevelLoaded;
    }

    private void Start()
    {
        OnLevelChange?.Invoke(SceneManager.GetActiveScene().name);
    }

    public static void LoadScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    private static void LevelLoaded(Scene scene, LoadSceneMode mode)
    {
        OnLevelChange?.Invoke(scene.name);
    }
}
