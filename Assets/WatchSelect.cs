using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchSelect : MonoBehaviour
{
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void WatchOneButtonClicked(){

        // 1) Show watch 1 model on uses wirst

        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        // 2) Animate watch 1 window


    }

    public void WatchTwoButtonClicked(){

        // 1) Show watch 2 model on uses wirst

        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        // 2) Animate watch 2 window

    }

    public void WatchThreeButtonClicked(){

        // 1) Show watch 3 model on uses wirst

        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);

        // 2) Animate watch 3 window

    }


}
