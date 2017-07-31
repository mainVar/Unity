//!Copyright(C) 2017 Panchenko Vladislav 
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  31/07/2017 | Panchenko Vladislav | Draw  grid by Gizmos
//
//******************************************************************************
using UnityEngine;

public class Grid : MonoBehaviour
{
    public float Width = 10f;
    public float Height = 10f;
    public bool Draw = true;

    public float CountLines = 10f;
   
    void OnDrawGizmos()
    {
        if (Width < 0.1f) Width = 0.1f;
        if (Height < 0.1f) Height = 0.1f;

        if (Draw)
        {
            var xVar = (CountLines / 2f) * Width;
            for (float x = -xVar; x < xVar; x += Width)
            {
                var c = Mathf.Floor(x / Width) * Width + Width / 2f;
                var a = new Vector3(c,0, -CountLines * Width / 2f - Width / 2f);
                var b = new Vector3(c,0,CountLines * Width / 2f - Width / 2f);
                Gizmos.color = Color.white;
                Gizmos.DrawLine(a, b);
          

            }

            var zVar = (CountLines / 2f) * Height;
            for (float z = -zVar; z < zVar; z += Height)
            {
                var c = Mathf.Floor(z / Height) * Height + Height / 2f;
                var a = new Vector3(-CountLines * Height / 2f - Height / 2f,0, c);
                var b = new Vector3(CountLines * Height / 2f - Height / 2f,0, c);
                Gizmos.DrawLine(a,b);
             
            }
        }

    }
}