using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuplicateObject : MonoBehaviour
{
    int donutCount = 0;
    int coffeeCount = 0;
    public GameObject Donut2;
    public GameObject Coffee2;
    double x = -12.49;
    double newX = 4.49;
    public Text win;

    // Start is called before the first frame update
    void Start()
    {

    }


    public void duplicateDonut()
    {
        //duplicate donut
        if(donutCount < 4)
        {
            x = x - 2;
            //Destroy(this.gameObject);
            Instantiate(Donut2, new Vector3((float)x, (float)0.09, (float)-22.11), Quaternion.identity);
            donutCount++;

        }
        else
        {
            displayMessage();
        }

    }

    public void duplicateCoffee()
    {
        //duplicate coffee
        if(coffeeCount < 4)
        {
            
            Instantiate(Coffee2, new Vector3((float)newX, (float)1.64, (float)3.31), Quaternion.identity);
            coffeeCount++;
            newX = newX - 2;
        }
    }

    public void displayMessage()
    {
        //display end game message
        this.win.text = "We are Closed";
        Debug.Log("We are Closed");
    }
}
