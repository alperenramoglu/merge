using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObj : MonoBehaviour
{

    //public Transform pos;
    public GameObject[] objectToInstatiate;
    //public bool Obj;
    public GameObject myObj;
    public GameObject parent;
    public static bool isEmpty = false;
    public static bool twoChild = false;

   

    // Start is called before the first frame update
    void Start()
    {
        
        InstantiateObject();
    }

    // Update is called once per frame
    void Update()
    {

        if (parent.transform.childCount == 0 && isEmpty == true )
        {
            //isEmpty = true;
            InstantiateObject();

            




        }
        if (parent.transform.childCount == 2  && DragObject.same == false)
        {
           
            Destroy(parent.transform.GetChild(0).gameObject);
            
        }

        if (parent.transform.childCount ==2)
        {
            twoChild = true;
        }
        isEmpty = true;
        
    }
    public void InstantiateObject()
    {
        int n = Random.Range(0, objectToInstatiate.Length);
        GameObject myObj = Instantiate<GameObject>(objectToInstatiate[n], transform.position, objectToInstatiate[n].transform.rotation);
        myObj.transform.parent = parent.transform;
        isEmpty = false;
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (this.gameObject.tag == "Base" && collision.gameObject.tag == "Wheel2" )
        {
            collision.transform.parent = parent.transform;

            /*if (parent.transform.childCount == 2 && DragObject.same == false)
            {
                Destroy(parent.transform.GetChild(0).gameObject);

            }*/
            
            

        }
        if (this.gameObject.tag == "Base" && collision.gameObject.tag == "Wheel3")
        {
            collision.transform.parent = parent.transform;
            collision.gameObject.GetComponent<Collider2D>().enabled = false;
           /*/ if (parent.transform.childCount == 2 && DragObject.same == false)
            {
                Destroy(parent.transform.GetChild(0).gameObject);

            }*/

        }

        if (this.gameObject.tag == "Base" && collision.gameObject.tag == "Tire2" )
        {
            collision.transform.parent = parent.transform;
           /* if (parent.transform.childCount == 2 && DragObject.same == false)
            {
                Destroy(parent.transform.GetChild(0).gameObject);

            }*/
        }
        if (this.gameObject.tag == "Base" && collision.gameObject.tag == "Tire3")
        {
            collision.transform.parent = parent.transform;
            collision.gameObject.GetComponent<Collider2D>().enabled = false;
            /*if (parent.transform.childCount == 2 && DragObject.same == false)
            {
                Destroy(parent.transform.GetChild(0).gameObject);

            }*/

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        if (this.gameObject.tag == "Base" && collision.gameObject.tag == "Electric2")
        {
            collision.transform.parent = parent.transform;

            /*if (parent.transform.childCount == 2 && DragObject.same == false)
            {
                Destroy(parent.transform.GetChild(0).gameObject);

            }*/



        }
        if (this.gameObject.tag == "Base" && collision.gameObject.tag == "Electric3")
        {
            collision.transform.parent = parent.transform;
            collision.gameObject.GetComponent<Collider2D>().enabled = false;
            /*/ if (parent.transform.childCount == 2 && DragObject.same == false)
             {
                 Destroy(parent.transform.GetChild(0).gameObject);

             }*/

        }

        if (this.gameObject.tag == "Base" && collision.gameObject.tag == "Gear2")
        {
            collision.transform.parent = parent.transform;
            /* if (parent.transform.childCount == 2 && DragObject.same == false)
             {
                 Destroy(parent.transform.GetChild(0).gameObject);

             }*/
        }
        if (this.gameObject.tag == "Base" && collision.gameObject.tag == "Gear3")
        {
            collision.transform.parent = parent.transform;
            collision.gameObject.GetComponent<Collider2D>().enabled = false;
            /*if (parent.transform.childCount == 2 && DragObject.same == false)
            {
                Destroy(parent.transform.GetChild(0).gameObject);

            }*/

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
   
}
