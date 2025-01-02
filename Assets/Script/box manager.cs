using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmanager : MonoBehaviour
{    
    public void OnMouseDown()
    {
        if (gameObject.CompareTag("box1"))
        {
            GameManager.Instance.SetupBoard1();
        }
        else if (gameObject.CompareTag("box2"))
        {
            GameManager.Instance.SetupBoard2();           
        }
        else if (gameObject.CompareTag("box3"))
        {
            GameManager.Instance.SetupBoard3();
        }
        else if (gameObject.CompareTag("box4"))
        {
            GameManager.Instance.SetupBoard4();
        }
    }
}
