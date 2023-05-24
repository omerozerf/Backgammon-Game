using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWorld : MonoBehaviour
{
    public static MouseWorld Instance;
    
    
    private Camera mainCamera;


    private void Awake()
    {
        Instance = this;
    }


    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        GetSlot();
    }

    public GameObject GetSlot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("Slot"))
                {
                    print(hitInfo.collider.gameObject);
                    return hitInfo.collider.gameObject;
                }
            }
        }

        return null;
    }
}
