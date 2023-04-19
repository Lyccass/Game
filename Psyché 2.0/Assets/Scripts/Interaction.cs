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
        // TODO: More interactable-tags (Box, key, door, etc.). Maybe store current collider2D and access it later!
        // TODO: All of these colliders must implement a "interact" function, based on the job it should do!
        // (For example: doors interact() opens it, changes to a specific sprite etc.)
        if (other.CompareTag("Interactable"))
        {
          //  Debug.Log("Trigger active!");
            triggerActive = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
           // Debug.Log("Trigger deactive!");
            triggerActive = false;
        }
    }

    private void Update()
    {

        if (triggerActive && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Interaction");
            SomeCoolAction();

        }

        if (PlayerController.hidden == true)
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

        if (PlayerController.hidden == true)
        {

            PlayerController.hidden = false;


        }
        else
        {
            PlayerController.hidden  = true;
        }

       

    }
}