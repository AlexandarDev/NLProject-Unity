using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameContoller : MonoBehaviour {
    [SerializeField]
    private InputField input;
    public string Binary ;
    public string Massege;
    public bool isDecimalequalstoBinary;
    public bool isNotDecimalequalstoBinary = true;
    private int number;

    public int trueThreeTimes = 1;
    public GUIStyle myGUIStyle;
    

    public void GetInput(string guess)
    {
     
            CompareGuesses(int.Parse(guess));
            input.text = "";
  
    }

    void Start()
    {
        Random random = new Random();
        number = Random.Range(1, 1000);
         string binarynum = Enumerable.Range(0, (int)Mathf.Log(number, 2) + 1).Aggregate(string.Empty, (collected, bitshifts) => (number >> bitshifts) % 2 + collected);
        Debug.Log(binarynum);
        Debug.Log(number);
        Massege = binarynum;
    }
    void CompareGuesses(int guess)
    {
        if (guess == number)
        {
            isDecimalequalstoBinary = true;
        }
        if (guess != number)
        {
            isNotDecimalequalstoBinary = false;
        }
    }
    void Update()
    {
       
  
            if (isDecimalequalstoBinary == true )
            {
            isDecimalequalstoBinary = false;
            Start();
            trueThreeTimes = trueThreeTimes + 1;
            Debug.Log(trueThreeTimes);
            }
        if (trueThreeTimes == 3)
        {
            Application.LoadLevel("SampleScene 1");
        }
        if(isNotDecimalequalstoBinary == false)
        {
            Application.LoadLevel("SampleScene 2");
        }
        
    }
    void OnGUI()
    {
        GUI.Label(new Rect(400, 370, 1000, 200), Massege, myGUIStyle);
    }
}

