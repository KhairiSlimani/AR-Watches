using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ColorSelect : MonoBehaviour
{

    public Material band1;
    public Material band2;
    public Material band3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void w1ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "Black Button")
        {
            // Change the color to black
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#131313", out myColor);
            band1.color = myColor;

        }

        else if (buttonName == "Blue Button")
        {
            // Change the color to blue
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#2D2D2D", out myColor);
            band1.color = myColor;
        }

    }


    public void w2ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "Black Button")
        {
            // Change the color to black
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#131313", out myColor);
            band2.color = myColor;
        }
        else if (buttonName == "Red Button")
        {
            // Change the color to red
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#740202", out myColor);
            band2.color = myColor;
        }

    }


    public void w3ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "Black Button")
        {
            // Change the color to black
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#383838", out myColor);
            band3.color = myColor;
        }
        else if (buttonName == "Silver Button")
        {
            // Change the color to silver
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#9D9D9D", out myColor);
            band3.color = myColor;
        }

    }

}
