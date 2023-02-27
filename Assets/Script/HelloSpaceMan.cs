using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloSpaceMan : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        MainManager.instance.loadName();
        GetComponent<TextMeshProUGUI>().text="hello,"+MainManager.instance.playerName+",welcome to out space ";
    }

   
}
