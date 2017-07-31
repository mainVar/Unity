//!Copyright(C) 2017 Panchenko Vladislav
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  31/07/2017 | Panchenko Vladislav | menu UI
//
//******************************************************************************
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject playerUI;
    public Transform mCamera;
    Quaternion CamRotation;
    public GameObject UI_text;
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
            timerFROM_TRIGERS = timer -0.9f;
            timerFROM_TRIGERS -= Time.deltaTime;
        }
        if (timer <= 0)
        {
           
             Trees.bild_time = false; // Stops  RaycastHit in  Trees
           

        }
        if (timerFROM_TRIGERS<=0)
        {
            Trees.end = false;
          //  UITEXT();
        }

    }
    private void UITEXT()
    {
        if (Trees.bild_time == false)// set off text info & timer text
        {
            UI_text.SetActive(!UI_text.activeSelf);
        }
    }
    public void addTrees_1()
    {
        payerMenu();// off menu bild
        trees1.tag = "Object";
        Instantiate(trees1, new Vector3(60, 0, 30), Quaternion.identity);
        UI_text.SetActive(!UI_text.activeSelf);// set active  text info & timer text
        trees1.tag = "free";
        CreateObj = true;
        Trees.bild_time = true;
        Trees.end = true;
        timer = 5f;
       
        
    }
    public void addTrees_2()
    {
        payerMenu();// off menu bild
        trees2.tag = "Object";
        Instantiate(trees2, new Vector3(70, 0, 40), Quaternion.identity);
        UI_text.SetActive(!UI_text.activeSelf);// set active  text info & timer text
        trees2.tag = "free";
        CreateObj = true;
        Trees.bild_time = true;
        Trees.end = true;
        timer = 5f;

    }
    public void addTrees_3()
    {
        payerMenu();// off menu bild
        trees2.tag = "Object";
        Instantiate(trees3, new Vector3(80, 0, 60), Quaternion.identity);
        UI_text.SetActive(!UI_text.activeSelf);// set active  text info & timer text
        trees2.tag = "free";
        CreateObj = true;
        Trees.bild_time = true;
        Trees.end = true;
        timer = 5f;

    }
   
    public void Right()
    {

        // OnMouseDrag
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //  Pos z=105  x=90
        // set game plane               {
        //if (mousePos.x > 90f) ;

        //    mousePos.x = 90f;
        //else
        //    mousePos;                 }  = mousePos.x = mousePos.x < 90f ? 90f : mousePos.x
        mousePos.z = mousePos.z > 105f ? 105f : mousePos.z;//check position
        mousePos.x = mousePos.x > 90f ? 90f : mousePos.x;
        //  mCamera.position = new Vector3(mCamera.position.x, mCamera.position.y, (mCamera.position.z +10f));
        mCamera.position = Vector3.MoveTowards(mCamera.position,
            new Vector3(mousePos.x + 4.5f, mousePos.y, mousePos.z + 10f),
            speed * Time.deltaTime);

    }
    public void Left()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //max x=75 z=30
        mousePos.z = mousePos.z < 30f ? 30f : mousePos.z;//check position
        mousePos.x = mousePos.x < 60f ? 60f : mousePos.x;
        //  mCamera.position = new Vector3(mCamera.position.x, mCamera.position.y, (mCamera.position.z -10f));
        mCamera.position = Vector3.MoveTowards(mCamera.position,
            new Vector3(mousePos.x - 4.5f, mousePos.y, mousePos.z-10f),
            speed * Time.deltaTime);
    }
 
    public void Down ()
    {
        // min y=10
        
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = mousePos.y < 15f ? 15f : mousePos.y;//check position
        mCamera.position = Vector3.MoveTowards(mCamera.position,
           new Vector3(mousePos.x, mousePos.y-5f, mousePos.z),
           speed * Time.deltaTime);

        // rotation exempl 

        // float angle=50; 
        // Quaternion CamRotation = Quaternion.AngleAxis(angle, Vector3.up);
        //  transform.rotation = CamRotation * CamRotation;
    }
    public void Up()
    {
        //max y=80
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = mousePos.y > 80f ? 80f : mousePos.y; //check position 
        mCamera.position = Vector3.MoveTowards(mCamera.position,
           new Vector3(mousePos.x, mousePos.y + 5f, mousePos.z),
           speed * Time.deltaTime);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
