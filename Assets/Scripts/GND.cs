//!Copyright(C) 2017 Panchenko Vladislav 
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  31/07/2017 | Panchenko Vladislav | Generate earths
//
//******************************************************************************
using UnityEngine;

public class GND : MonoBehaviour
{
    public GameObject earth;
    public GameObject earthLongX;
    public GameObject earthLongY;
    public GameObject treesOnTop;
    public GameObject trees1;
    public GameObject trees2;
    public GameObject trees3;
    public float sizeX = 10;
    public float sizeZ = 10;
    // Use this for initialization
    //------------------------------------------------------
    void Start()
    {
        // game plane x=10->100 z=10->100
        for (int x = 1; x <= sizeX; x++)
        {
            for (int z = 1; z <= sizeZ; z++)
            {
                Instantiate(earth, new Vector3(x * 10, 1, z * 10), Quaternion.identity);
            }
        }
        //------------------------------------------------------
        // Environment (trees)
        #region trees left 

        for (int x = 1; x <= 4; x++)
        {
               // range 10-100 on X
                Instantiate(trees1, new Vector3(Random.Range(10, 100), 1, Random.Range(0, -10)), Quaternion.identity);
                Instantiate(trees2, new Vector3(Random.Range(10, 50), 1, Random.Range(0, -10)), Quaternion.identity);
                Instantiate(trees2, new Vector3(Random.Range(50, 100), 1, Random.Range(0, -10)), Quaternion.identity);
            
        }
        for (int x = 1; x <= 10; x++)
        {
             
                Instantiate(earthLongX, new Vector3(x * 10, 1, -5), Quaternion.identity);

                Instantiate(trees3, new Vector3(x * 10, 0, -20), Quaternion.identity);
            
        }
        #endregion 
        //------------------------------------------------------
        #region trees top 
        for (int z = 1; z <= 4; z++)
        {
            // range 10-100 on Z
            Instantiate(trees1, new Vector3(Random.Range(0,-10), 1, Random.Range(0, 100)), Quaternion.identity);
            Instantiate(trees2, new Vector3(Random.Range(0,-10), 1, Random.Range(10, 50)), Quaternion.identity);
            Instantiate(trees2, new Vector3(Random.Range(0,-10), 1, Random.Range(50, 100)), Quaternion.identity);

        }
        for (int z = 1; z <= 10; z++)
        {

            Instantiate(earthLongY, new Vector3(-5, 1,z*10), Quaternion.identity);
            Instantiate(trees3, new Vector3(-20, 0, z*10), Quaternion.identity);

        }
        #endregion
        //------------------------------------------------------
        // add trees on top Square
        Instantiate(treesOnTop, new Vector3(-20, -64, 30), Quaternion.identity);
    }
}
