using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    bool hidden = false;

    public GameObject box;
    

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
          //  Debug.Log("Trigger active!");
            triggerActive = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           // Debug.Log("Trigger deactive!");
            triggerActive = false;
        }
    }

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.F))
        {
            SomeCoolAction();



        }

        if (PlayerMovement.hidden == true)
        {
            box.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
        }
        else
        {
            box.GetComponent<SpriteRenderer>().sortingLayerName = "Background";
        }

    }

    public void SomeCoolAction()
    {

        if (PlayerMovement.hidden == true)
        {

            PlayerMovement.hidden = false;


        }
        else
        {
            PlayerMovement.hidden  = true;
        }

       

    }
}