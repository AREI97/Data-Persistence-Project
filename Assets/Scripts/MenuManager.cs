using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    private string userName;
    public TMP_InputField inputName;
    // Start is called before the first frame update
    void Start()
    {
        inputName.onValueChanged.AddListener(InputName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameStart()
    {
        GameManager.instance.Load();
        GameManager.instance.playerName = userName;
        SceneManager.LoadScene(1);
    }
    public void InputName(string name)
    {
        userName = name;
    }
}
