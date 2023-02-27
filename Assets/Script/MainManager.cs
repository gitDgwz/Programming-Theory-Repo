using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;

    public TextMeshProUGUI nameText;

    public string playerName;

    [SerializeField]
     class SpaceManName
    {
       public  string name;
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        instance = this;
        DontDestroyOnLoad(this);

    }

    public void begin()
    {
        saveName();
        SceneManager.LoadScene(1);
    }

    public void saveName()
    {
        SpaceManName space = new SpaceManName();
        space.name= nameText.text;
        string json = JsonUtility.ToJson(space);
        Debug.Log(json);
        File.WriteAllText(Application.persistentDataPath + "/saveName.json", json);
    }

    public void loadName()
    {
        string path = Application.persistentDataPath + "/saveName.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(Application.persistentDataPath + "/saveName.json");
            SpaceManName space=  JsonUtility.FromJson<SpaceManName>(json);
            playerName = space.name;
        }
      

    }
}
