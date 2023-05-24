using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public static UserInput Instance;
    
    
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
        GetMouseClick();
    }

    public void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("Slot"))
                {
                    print("Slot = " + hitInfo.collider.gameObject);
                }

                else if (hitInfo.collider.CompareTag("White"))
                {
                    print("White = " + hitInfo.collider.gameObject);
                }
                
                else if (hitInfo.collider.CompareTag("Black"))
                {
                    print("Black = " + hitInfo.collider.gameObject);
                }
            }
        }
    }
}
