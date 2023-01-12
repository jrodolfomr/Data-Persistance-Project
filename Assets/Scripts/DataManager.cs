using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static DataManager Instance;

    public string Name; // new variable declared
   

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Debug.Log("Initializing data manager");
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
