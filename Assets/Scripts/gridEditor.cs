﻿//!Copyright(C) 2017 Panchenko Vladislav
//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  31/07/2017 | Panchenko Vladislav | sub menu / in update Draw grid
//
//******************************************************************************
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Grid))]
public class GridEditor : Editor
{

    Grid grid;

    void OnEnable() { EditorApplication.update += Update; }

    [MenuItem("Grid")]
    public static void Init()
    {
        new GameObject("Grid", typeof(Grid)); //set name (always)
    }

    public override void OnInspectorGUI()  // sub menu
    {
        grid = (Grid)target;

        EditorGUILayout.LabelField("Настройка шага:", EditorStyles.boldLabel);
        grid.Width = EditorGUILayout.FloatField("По оси X", grid.Width);
        grid.Height = EditorGUILayout.FloatField("По оси Y", grid.Height);
        grid.Draw = EditorGUILayout.Toggle("Показывать", grid.Draw);

        EditorGUILayout.LabelField("Настройка сетки:", EditorStyles.boldLabel);
        grid.CountLines = EditorGUILayout.IntSlider("Кол-во линий", (int)grid.CountLines, 1, 1000);

        EditorGUILayout.LabelField("Выбранные объекты:", EditorStyles.boldLabel);
        foreach (var obj in Selection.objects)
        {
            EditorGUILayout.TextField("Имя объекта:", obj.name);
        }

        grid.name = "Grid";
        EditorUtility.SetDirty(grid);

        
    }

    void Update()
    {
        grid = (Grid)target;

        if (grid.Draw)
        {
            foreach (var obj in Selection.objects)
            {
                Vector3 pos = (obj as GameObject).transform.position;
                float x = Mathf.CeilToInt(pos.x / grid.Width) * grid.Width;
                float y = pos.y;
                float z = Mathf.CeilToInt(pos.z / grid.Height) * grid.Height;
                (obj as GameObject).transform.position = new Vector3(x, y, z);
            }
        }
    }

}