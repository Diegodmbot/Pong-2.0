using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    private bool appersToPlayer1 = false;
    private bool isShowing = false;
    private bool appersToPlayer2 = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isShowing)
        {
            if(appersToPlayer1)
            {
                StartCoroutine(ShowMoneyToPlayer1());
            }
            if (appersToPlayer2)
            {
                StartCoroutine(ShowMoneyToPlayer2());
            }
            isShowing = true;
        }
    }

    private IEnumerator ShowMoneyToPlayer1()
    {
        //yield return new WaitForSeconds(1);
        //GetComponent<Renderer>().enabled = true;
        //transform.position = new Vector3(Random.Range(-8, -7), Random.Range(-4, 4), 0);
    }

    private IEnumerator ShowMoneyToPlayer2()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Renderer>().enabled = true;
        transform.position = new Vector3(Random.Range(7, 8), Random.Range(-4, 4), 0);
        isShowing = true;
    }

    public void ShowToPlayer1()
    {
        appersToPlayer1 = true;
    }

    public void ShowToPlayer2()
    {
        appersToPlayer2 = true;
    }
}
