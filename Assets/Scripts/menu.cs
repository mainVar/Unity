using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject playerUI;
    public Transform mCamera;
    public GameObject trees1;
    public GameObject trees2;
    public GameObject trees3;
    
    public static bool CreateObj = false;
    [SerializeField]
    private float speed = 1f;
    public float timer ;
    private float timerFROM_TRIGERS =  - 1f;
    public Text timerText;
    public void payerMenu()
    {
        playerUI.SetActive(!playerUI.activeSelf);
    }
 
    void Update() //using for timer (time (onli) - TIME)
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("Осталось:") + timer.ToString("f1");
            timerFROM_TRIGERS = timer - 1f;
            timerFROM_TRIGERS -= Time.deltaTime;
        }
        if (timer <= 0)
        {
           
             Trees.bild_time = false; // Stops  RaycastHit in  Trees
           

        }
        if (timerFROM_TRIGERS<=0)
        {
            Trees.end = false;
        }
    }

    public void addTrees_1()
    {
        Instantiate(trees1, new Vector3(60, 0, 30), Quaternion.identity);
        CreateObj = true;
        Trees.bild_time = true;
        timer = 5f;
        
    }
    public void addTrees_2()
    {
        Instantiate(trees2, new Vector3(70, 0, 40), Quaternion.identity);
        CreateObj = true;
        Trees.bild_time = true;
        timer = 5f;
    }
    public void addTrees_3()
    {
        Instantiate(trees3, new Vector3(80, 0, 50), Quaternion.identity);
        //trees3.tag = "Busy";
        CreateObj = true;
        Trees.bild_time = true;
        timer = 5f;
    }
   
    public void Right()
    {

        // OnMouseDrag();
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //  mousePos.z = mousePos.z + 1f;
        //  mCamera.position = new Vector3(mCamera.position.x, mCamera.position.y, (mCamera.position.z +10f));
        mCamera.position = Vector3.MoveTowards(mCamera.position,
            new Vector3(mousePos.x + 4.5f, mousePos.y, mCamera.position.z + 10f),
            speed * Time.deltaTime);

    }
    public void Left()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //  mousePos.z = mousePos.z + 1f;
        //  mCamera.position = new Vector3(mCamera.position.x, mCamera.position.y, (mCamera.position.z +10f));
        mCamera.position = Vector3.MoveTowards(mCamera.position,
            new Vector3(mousePos.x - 4.5f, mousePos.y, mCamera.position.z - 10f),
            speed * Time.deltaTime);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
