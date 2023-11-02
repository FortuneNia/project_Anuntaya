using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainUI : MonoBehaviour
   
{
    [SerializeField]
    private TMP_Text NotiText;


    public static MainUI Instance;
    // Start is called before the first frame update
    void Start()
    {
         Instance = this;
    }

    // Update is called once per frame
    public void ShowNotiText(string s)
    {
        NotiText.text = s;
    }
}
