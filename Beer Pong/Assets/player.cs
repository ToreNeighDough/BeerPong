using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public GameObject Player;
    public Rigidbody rigid;
    private float power;
    public GameObject[] cubes;
    public Material[] cubeColours;
    private int number;
    private bool shotTaken;
    public GameObject[] cams;
    public GameObject[] playerCups;
    public GameObject[] comCups;

    // Use this for initialization
    void Start()
    {
        shotTaken = false;
        power = 0;
        number = 0;
        InvokeRepeating("PowerBar", 1, .05f);
    }

    private void PowerBar()
    {
        
        cubes[number].GetComponent<MeshRenderer>().material = cubeColours[0];
        number++;

        if(number >= cubes.Length)
        {
            number = 28;
            CancelInvoke("PowerBar");
            InvokeRepeating("PowerBarTwo", .05f, .05f);
        }
    }

    void PowerBarTwo()
    {
        cubes[number].GetComponent<MeshRenderer>().material = cubeColours[1];
        number--;

        if (number == 0)
        {
            number = 0;
            CancelInvoke("PowerBarTwo");
            InvokeRepeating("PowerBar", .05f, .05f);
        }
    }

    public void Left()
    {
        Player.transform.Translate(new Vector3(-1, 0, 0));
    }
    
    public void Right()
    {
        Player.transform.Translate(new Vector3(1, 0, 0));
    }

    // Update is called once per frame
    public void Power()
    {
            switch (number)
            {
                case 0:
                    power = 1;
                    break;

                case 1:
                    power = 2;
                    break;

                case 2:
                    power = 3;
                    break;

                case 3:
                    power = 4;
                    break;

                case 4:
                    power = 5;
                    break;

                case 5:
                    power = 6;
                    break;

                case 6:
                    power = 7;
                    break;

                case 7:
                    power = 8;
                    break;

                case 8:
                    power = 9;
                    break;

                case 9:
                    power = 10;
                    break;

                case 10:
                    power = 11;
                    break;

                case 11:
                    power = 12;
                    break;

                case 12:
                    power = 13;
                    break;

                case 13:
                    power = 14;
                    break;

                case 14:
                    power = 15;
                    break;

                case 15:
                    power = 16;
                    break;

                case 16:
                    power = 17;
                    break;

                case 17:
                    power = 18;
                    break;

                case 18:
                    power = 19;
                    break;

                case 19:
                    power = 20;
                    break;

                case 20:
                    power = 21;
                    break;

                case 21:
                    power = 22;
                    break;

                case 22:
                    power = 23;
                    break;

                case 23:
                    power = 24;
                    break;

                case 24:
                    power = 25;
                    break;

                case 25:
                    power = 26;
                    break;

                case 26:
                    power = 27;
                    break;

                case 27:
                    power = 28;
                    break;

                case 28:
                    power = 29;
                    break;

                case 29:
                    power = 30;
                    break;

            }
            shotTaken = true;
            CancelInvoke("PowerBar");
            CancelInvoke("PowerBarTwo");
            rigid.AddForce(Vector3.forward * power);
            rigid.AddForce(Vector3.up * power);
            rigid.useGravity = true;

    }

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "playerTwo")
        {
            Debug.Log("Collision With Player Two");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "switchCam")
        {
            cams[0].SetActive(false);
            cams[1].SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {

    }
}
