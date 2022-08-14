using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button monday, tuesday, wednesday, thursday, friday, saturday, sunday;
    // Start is called before the first frame update
    void Start()
    {
        switch (System.DateTime.Now.DayOfWeek)
        {
            case System.DayOfWeek.Monday:
                monday.GetComponent<Image>().color = Color.green;
                break;
            case System.DayOfWeek.Tuesday:
                tuesday.GetComponent<Image>().color = Color.green;
                break;
            case System.DayOfWeek.Wednesday:
                wednesday.GetComponent<Image>().color = Color.green;
                break;
            case System.DayOfWeek.Thursday:
                thursday.GetComponent<Image>().color = Color.green;
                break;
            case System.DayOfWeek.Friday:
                friday.GetComponent<Image>().color = Color.green;
                break;
            case System.DayOfWeek.Saturday:
                saturday.GetComponent<Image>().color = Color.green;
                break;
            case System.DayOfWeek.Sunday:
                sunday.GetComponent<Image>().color = Color.green;
                break; 
            
        }
        Debug.Log(System.DateTime.Now.DayOfWeek);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadLevel(int level)
    {
        SceneManager.LoadScene(level);
    }
}
