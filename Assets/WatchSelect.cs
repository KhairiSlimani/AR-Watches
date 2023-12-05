using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelect : MonoBehaviour
{
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject watchWindow1;
    public GameObject watchWindow2;
    public GameObject watchWindow3;

    public Animation watchWindow1Animation;
    public Animation watchWindow2Animation;
    public Animation watchWindow3Animation;

    // Start is called before the first frame update
    void Start()
    {
        watchWindow1Animation = watchWindow1.GetComponent<Animation>();
        watchWindow2Animation = watchWindow2.GetComponent<Animation>();
        watchWindow3Animation = watchWindow3.GetComponent<Animation>();
    }
    
    public void WatchOneButtonClicked()
    {
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        watchWindow1Animation["Window 1 Animation"].speed = 1;
        watchWindow1Animation.Play();
    }

    public void WatchTwoButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        watchWindow2Animation["Window 2 Animation"].speed = 1;
        watchWindow2Animation.Play();
    }

    public void WatchThreeButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);

        watchWindow3Animation["Window 3 Animation"].speed = 1;
        watchWindow3Animation.Play();
    }

    public void CloseButtonClicked()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
    
        if (buttonName == "w1close button")
        {
            watchModel1.SetActive(false);
            watchWindow1Animation["Window 1 Animation"].speed = -1;
            watchWindow1Animation["Window 1 Animation"].time = watchWindow1Animation["Window 1 Animation"].length;
            watchWindow1Animation.Play();
        }

        else if (buttonName == "w2close button")
        {
            watchModel2.SetActive(false);
            watchWindow2Animation["Window 2 Animation"].speed = -1;
            watchWindow2Animation["Window 2 Animation"].time = watchWindow2Animation["Window 2 Animation"].length;
            watchWindow2Animation.Play();
        }

        else if (buttonName == "w3close button")
        {
            watchModel3.SetActive(false);
            watchWindow3Animation["Window 3 Animation"].speed = -1;
            watchWindow3Animation["Window 3 Animation"].time = watchWindow3Animation["Window 3 Animation"].length;
            watchWindow3Animation.Play();
        }
    }

}
