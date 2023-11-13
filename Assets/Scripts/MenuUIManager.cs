using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuUIManager : MonoBehaviour
{
    [SerializeField] private GameObject eventPanelUserInRange;
    bool isUIPanelActive;
    public Text distanceText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DiplayStartEventPanel(double distance)
    {
        if(isUIPanelActive == false)
        {
            eventPanelUserInRange.SetActive(true);
            distanceText.text = "Your destenation is " + distance.ToString("F2") + " meters";
            isUIPanelActive = true;
        }           
    }

    public void CloseButtonClick()
    {
        eventPanelUserInRange.SetActive(false);
        isUIPanelActive = false;

    }
}
