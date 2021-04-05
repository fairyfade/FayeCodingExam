using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour
{
    private bool HAS_FIRED;
    public GameObject Donut;
    
    public void Start()
    {
        HAS_FIRED = false;
    }

    public void coffeCupChange()
    {
        if(HAS_FIRED == false)
        {
            
            //insert code here
            Destroy(this.gameObject);
            Instantiate(Donut, new Vector3((float)-1.46, (float)1.53, (float)2.976551), Quaternion.identity);
            HAS_FIRED = true;
        }
    }
}
