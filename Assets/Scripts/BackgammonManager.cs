using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgammonManager : MonoBehaviour
{
    [SerializeField] private GameObject[] slotArray;

    [SerializeField] private GameObject whitePrefab;
    [SerializeField] private GameObject blackPrefab;


    private void Start()
    {
        Play();
    }

    private void Play()
    {
        StartCoroutine(Create5());
        StartCoroutine(Create3());
        StartCoroutine(Create2());
    }

    private IEnumerator Create2()
    {
        for (int i = 0; i < 2; i++)
        {
            yield return new WaitForSeconds(0.1f);

            
            float yPos = 1.5f;
            float zOrder = i * 5;

            // White

            Vector3 slot23Pos =
                new Vector3(slotArray[23].transform.position.x, yPos, slotArray[23].transform.position.z - zOrder);
            Instantiate(whitePrefab, slot23Pos, Quaternion.identity, slotArray[23].transform);


            // Black

            Vector3 slot0Pos = 
                new Vector3(slotArray[0].transform.position.x, yPos, slotArray[0].transform.position.z + zOrder);
            Instantiate(blackPrefab, slot0Pos, Quaternion.identity, slotArray[0].transform);
        }
    }

    private IEnumerator Create3()
    {
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(0.1f);
            
            
            float yPos = 1.5f;
            float zOrder = i * 5;

            // White

            Vector3 slot7Pos =
                new Vector3(slotArray[7].transform.position.x, yPos, slotArray[7].transform.position.z + zOrder);
            Instantiate(whitePrefab, slot7Pos, Quaternion.identity, slotArray[7].transform);


            // Black

            Vector3 slot16Pos =
                new Vector3(slotArray[16].transform.position.x, yPos, slotArray[16].transform.position.z - zOrder);
            Instantiate(blackPrefab, slot16Pos, Quaternion.identity, slotArray[16].transform);
        }
    }

    private IEnumerator Create5()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(0.1f);
            
            
            float yPos = 1.5f;
            float zOrder = i * 5;

            // White

            Vector3 slot5Pos =
                new Vector3(slotArray[5].transform.position.x, yPos, slotArray[5].transform.position.z + zOrder);
            Instantiate(whitePrefab, slot5Pos, Quaternion.identity, slotArray[5].transform);

            Vector3 slot12Pos = 
                new Vector3(slotArray[12].transform.position.x, yPos, slotArray[12].transform.position.z - zOrder);
            Instantiate(whitePrefab, slot12Pos, Quaternion.identity, slotArray[12].transform);


            // Black

            Vector3 slot18Pos = 
                new Vector3(slotArray[18].transform.position.x, yPos, slotArray[18].transform.position.z - zOrder);
            Instantiate(blackPrefab, slot18Pos, Quaternion.identity, slotArray[18].transform);

            Vector3 slot11Pos =
                new Vector3(slotArray[11].transform.position.x, yPos, slotArray[11].transform.position.z + zOrder);
            Instantiate(blackPrefab, slot11Pos, Quaternion.identity, slotArray[11].transform);
        }
    }
}
