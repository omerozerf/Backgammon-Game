using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgammonManager : MonoBehaviour
{
    [SerializeField] private Slot[] slotArray;

    [SerializeField] private Stone whitePrefab;
    [SerializeField] private Stone blackPrefab;


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
            Stone whiteStone = Instantiate(whitePrefab, slot23Pos, Quaternion.identity, slotArray[23].transform);
            slotArray[23].GetComponent<Slot>().AddStoneToList(whiteStone);


            // Black

            Vector3 slot0Pos = 
                new Vector3(slotArray[0].transform.position.x, yPos, slotArray[0].transform.position.z + zOrder);
            Stone blackStone = Instantiate(blackPrefab, slot0Pos, Quaternion.identity, slotArray[0].transform);
            slotArray[0].GetComponent<Slot>().AddStoneToList(blackStone);
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
            Stone whiteStone = Instantiate(whitePrefab, slot7Pos, Quaternion.identity, slotArray[7].transform);
            slotArray[7].GetComponent<Slot>().AddStoneToList(whiteStone);


            // Black

            Vector3 slot16Pos =
                new Vector3(slotArray[16].transform.position.x, yPos, slotArray[16].transform.position.z - zOrder);
            Stone blackStone = Instantiate(blackPrefab, slot16Pos, Quaternion.identity, slotArray[16].transform);
            slotArray[16].GetComponent<Slot>().AddStoneToList(blackStone);
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
            Stone whiteStone1 = Instantiate(whitePrefab, slot5Pos, Quaternion.identity, slotArray[5].transform);
            slotArray[5].GetComponent<Slot>().AddStoneToList(whiteStone1);
            

            Vector3 slot12Pos = 
                new Vector3(slotArray[12].transform.position.x, yPos, slotArray[12].transform.position.z - zOrder);
            Stone whiteStone2 = Instantiate(whitePrefab, slot12Pos, Quaternion.identity, slotArray[12].transform);
            slotArray[12].GetComponent<Slot>().AddStoneToList(whiteStone2);


            // Black

            Vector3 slot18Pos = 
                new Vector3(slotArray[18].transform.position.x, yPos, slotArray[18].transform.position.z - zOrder);
            Stone blackStone1 = Instantiate(blackPrefab, slot18Pos, Quaternion.identity, slotArray[18].transform);
            slotArray[18].GetComponent<Slot>().AddStoneToList(blackStone1);
            

            Vector3 slot11Pos =
                new Vector3(slotArray[11].transform.position.x, yPos, slotArray[11].transform.position.z + zOrder);
            Stone blackStone2 = Instantiate(blackPrefab, slot11Pos, Quaternion.identity, slotArray[11].transform);
            slotArray[11].GetComponent<Slot>().AddStoneToList(blackStone2);
        }
    }
}
