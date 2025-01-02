using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEditor.Experimental.GraphView;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
   
    public GameObject stonePrefab;
    public GameObject rockPrefab;

    [SerializeField] int gridSize = 5;
    private float stoneSpacing = 0.75f;
    private float rockSpacing = 0.65f;
    private float yOffset = -2;

    public TextMeshProUGUI pickaxeText;
    public int pickaxe ;
    public void Awake()
    {
        Instance = this;
    }
    private void Start() 
    {         
        pickaxe = 10;        
    }
    public void SetupBoard1()
    {
        float startX = -(gridSize - 1) * stoneSpacing / 2;
        float startY = -(gridSize - 1) * stoneSpacing / 2 + yOffset;
        for (int x = 0; x < gridSize; x++) 
        { 
            for (int y = 0; y < gridSize; y++)
            {
                Vector3 position = new Vector3(startX + x * stoneSpacing, startY + y * stoneSpacing, 0); 
                Instantiate(stonePrefab, position, Quaternion.identity);
            } 
        }
    }
    public void SetupBoard2() 
    {
        float startX = -(6 - 1) * stoneSpacing / 2;
        float startY = -(6 - 1) * stoneSpacing / 2 + yOffset;
        for (int x = 0; x < 6; x++)
        {
            for (int y = 0; y < 6; y++)
            {
                Vector3 position = new Vector3(startX + x * stoneSpacing, startY + y * stoneSpacing, 0);
                Instantiate(stonePrefab, position, Quaternion.identity);
            }
        }
    }
    public void SetupBoard3()
    {
        float startX = -(7 - 1) * rockSpacing / 2;
        float startY = -(7 - 1) * rockSpacing / 2 + yOffset;
        for (int x = 0; x < 7; x++)
        {
            for (int y = 0; y < 7; y++)
            {
                Vector3 position = new Vector3(startX + x * rockSpacing, startY + y * rockSpacing, 0);
                Instantiate(rockPrefab, position, Quaternion.identity);
            }
        }
    }
    public void SetupBoard4()
    {
        float startX = -(8 - 1) * rockSpacing / 2;
        float startY = -(8 - 1) * rockSpacing / 2 + yOffset;
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                Vector3 position = new Vector3(startX + x * rockSpacing, startY + y * rockSpacing, 0);
                Instantiate(rockPrefab, position, Quaternion.identity);
            }
        }
    }
    public void UpdatePickaxe()
    {
        //pickaxe -= pickaxeToAdd;
        pickaxeText.text = "pickaxe :" + pickaxe;
    }   
}
