using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class GameManager : MonoBehaviour
{
    public Player bestPlayer;
    public string playerName;
    public static GameManager instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }


    [Serializable]
    public class Player
    {
        public string playerName;
        public int playerScore;
        public Player(string playerName, int playerScore)
        {
            this.playerName = playerName;
            this.playerScore = playerScore;
        }

    }
    public void Save()
    {
        
        string json = JsonUtility.ToJson(instance.bestPlayer);
        Debug.Log(json);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            instance.bestPlayer = JsonUtility.FromJson<Player>(json);
        }
    }
}
