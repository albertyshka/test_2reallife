using UnityEngine;


/// <summary>
/// Базовый класс синглтона
/// </summary>
/// <typeparam name="T">Это тот класс, который наследует Singleton. Для надежности</typeparam>
/// <example> public class MyClass : Singleton<MyClass> </example>
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;
    public static T Instance
    {
        get { return instance; } // Нельзя задать значение извне, только получить его
    }

    public static bool IsInitialized
    {
        get { return instance != null; }
    }

    // protected virtual - наследуется, может быть переписан
    protected virtual void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("[Singleton] Trying to instantiate a second instance of a singleton class.");
        }
        else
        {
            instance = (T) this;
        }
    }

    protected virtual void OnDestroy()
    {
        if (instance == this) // Если уничтожен, то можно сделать новый
        {
            instance = null;
        }
    }
}
