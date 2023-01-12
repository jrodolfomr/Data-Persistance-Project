using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public  Button StartButton;
    public  InputField NameText;

    void Start()
    {
        Button btn = StartButton.GetComponent<Button>();
        btn.onClick.AddListener(ChangeScene);
        Debug.Log("loaded menu");
    }

    void ChangeScene()
    {
        Debug.Log("loading new scene: " + NameText.text);
        if (NameText.text != "") { 

            DataManager.Instance.Name = NameText.text;
            SceneManager.LoadScene("main", LoadSceneMode.Single); 
        }
    }
}
