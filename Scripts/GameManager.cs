using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    // что за уровень сейчас активен
    // загружать выгружать уровни
    // следить за сотоянием игры
    // генерировать другие системы

    private string currentLevelName = string.Empty;
    public string CurrentLevelName
    {
        get { return currentLevelName; }
    }


    List<AsyncOperation> loadOperations;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        loadOperations = new List<AsyncOperation>();
        LoadLevel("Main");
    }

    void OnLoadOperationComplete(AsyncOperation ao)
    {
        if (loadOperations.Contains(ao))
        {
            loadOperations.Remove(ao);

            // fadeOut boot scene
        }

        Debug.Log("Загрузка завершена.");
    }

    void OnUnloadOperationComplete(AsyncOperation ao)
    {
        Debug.Log("Выгрузка завершена.");
    }

    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Невозможно загрузить уровень " + levelName);
            return;
        }
            

        ao.completed += OnLoadOperationComplete;
        loadOperations.Add(ao);
        currentLevelName = levelName;
    }

    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Невозможно выгрузить уровень " + levelName);
            return;
        }

        ao.completed += OnUnloadOperationComplete;
    }
}
