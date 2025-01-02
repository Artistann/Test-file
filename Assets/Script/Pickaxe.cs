using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pickaxe : MonoBehaviour
{ 
    public void OnMouseDown()
    {
        if (GameManager.Instance.pickaxe>0) 
        {
            Destroy(gameObject);    
            GameManager.Instance.pickaxe--;
            GameManager.Instance.UpdatePickaxe();
        }
        else if (GameManager.Instance.pickaxe == 0) 
        {
            Debug.Log("Add 100 pickaxe?");
        }
    }
}
