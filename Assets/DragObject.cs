using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{

    private Vector3 mousePosition;
    private float offsetX, offsetY;
    public static bool mouseButtonReleased;
    GameObject child, parent;
    public static bool same = false;
    public Vector3 StartPos;
    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mouseButtonReleased = false;
        mousePosition = Input.mousePosition - GetMousePos();

    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }

    private void OnMouseUp()
    {
        mouseButtonReleased = true;
    }
    private void Start()
    {
        StartPos = this.transform.position;
    }
    private void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        /*string thisGameobjectName;
        string collisionGameobjectName;

        thisGameobjectName = gameObject.name.Substring(0, name.IndexOf("_"));
        collisionGameobjectName = collision.gameObject.name.Substring(0, name.IndexOf("_"));*/
        
        
            
            if (this.gameObject.tag == "Wheel3" && collision.gameObject.tag == "Wheel")
            {
            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }
                
            }
        if (this.gameObject.tag == "Wheel2" && collision.gameObject.tag == "Wheel")
        {
            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Wheel3" && collision.gameObject.tag == "Tire")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Wheel2" && collision.gameObject.tag == "Tire")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        ////////////////////////////////////////////////////////////////////
        if (this.gameObject.tag == "Wheel3" && collision.gameObject.tag == "Electric")
        {
            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Wheel2" && collision.gameObject.tag == "Electric")
        {
            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Wheel3" && collision.gameObject.tag == "Gear")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Wheel2" && collision.gameObject.tag == "Gear")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }

        ///////////////////////////////////////////////////////////////

        if ( this.gameObject.tag == "Tire3" && collision.gameObject.tag == "Tire")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Tire2" && collision.gameObject.tag == "Tire")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Tire3" && collision.gameObject.tag == "Wheel")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Tire2" && collision.gameObject.tag == "Wheel")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        //////////////////////////////////////////////////////////////////////////////////////////

        if (this.gameObject.tag == "Tire3" && collision.gameObject.tag == "Electric")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Tire2" && collision.gameObject.tag == "Electric")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Tire3" && collision.gameObject.tag == "Gear")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Tire2" && collision.gameObject.tag == "Gear")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        if (this.gameObject.tag == "Electric3" && collision.gameObject.tag == "Tire")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Electric2" && collision.gameObject.tag == "Tire")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Electric3" && collision.gameObject.tag == "Wheel")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Electric2" && collision.gameObject.tag == "Wheel")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        //////////////////////////////////////////////////////////////////////////////////////////

        if (this.gameObject.tag == "Electric3" && collision.gameObject.tag == "Electric")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Electric2" && collision.gameObject.tag == "Electric")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Electric3" && collision.gameObject.tag == "Gear")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Electric2" && collision.gameObject.tag == "Gear")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        ///
        if (this.gameObject.tag == "Gear3" && collision.gameObject.tag == "Tire")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Gear2" && collision.gameObject.tag == "Tire")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Gear3" && collision.gameObject.tag == "Wheel")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Gear2" && collision.gameObject.tag == "Wheel")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        //////////////////////////////////////////////////////////////////////////////////////////

        if (this.gameObject.tag == "Gear3" && collision.gameObject.tag == "Electric")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Gear2" && collision.gameObject.tag == "Electric")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Gear3" && collision.gameObject.tag == "Gear")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        if (this.gameObject.tag == "Gear2" && collision.gameObject.tag == "Gear")
        {

            if (InstantiateObj.twoChild == true)
            {
                Destroy(collision.gameObject);
            }

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        if (mouseButtonReleased ==true && this.gameObject.tag == "Wheel" && collision.gameObject.tag == "Wheel" )
        {
            Instantiate(Resources.Load("Wheel2"), transform.position, Quaternion.identity);
            
            mouseButtonReleased = false;
            same = true;
            //InstantiateObj.isEmpty = false;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            
        }
        else if (mouseButtonReleased == true && this.gameObject.tag == "Wheel2" && collision.gameObject.tag == "Wheel2")
        {
            Instantiate(Resources.Load("Wheel3"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            same = true;


            //InstantiateObj.isEmpty = false;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }
        

        if (mouseButtonReleased == true && this.gameObject.tag == "Tire" && collision.gameObject.tag == "Tire")
        {
            Instantiate(Resources.Load("Tire2"), transform.position, Quaternion.identity);

            mouseButtonReleased = false;
            same = true;


            //InstantiateObj.isEmpty = false;

            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else if (mouseButtonReleased == true && this.gameObject.tag == "Tire2" && collision.gameObject.tag == "Tire2")
        {
            Instantiate(Resources.Load("Tire3"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            same = true;


            //InstantiateObj.isEmpty = false;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        if (mouseButtonReleased == true && this.gameObject.tag == "Electric" && collision.gameObject.tag == "Electric")
        {
            Instantiate(Resources.Load("Electric2"), transform.position, Quaternion.identity);

            mouseButtonReleased = false;
            same = true;
            //InstantiateObj.isEmpty = false;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }
        else if (mouseButtonReleased == true && this.gameObject.tag == "Electric2" && collision.gameObject.tag == "Electric2")
        {
            Instantiate(Resources.Load("Electric3"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            same = true;


            //InstantiateObj.isEmpty = false;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }


        if (mouseButtonReleased == true && this.gameObject.tag == "Gear" && collision.gameObject.tag == "Gear")
        {
            Instantiate(Resources.Load("Gear2"), transform.position, Quaternion.identity);

            mouseButtonReleased = false;
            same = true;


            //InstantiateObj.isEmpty = false;

            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else if (mouseButtonReleased == true && this.gameObject.tag == "Gear2" && collision.gameObject.tag == "Gear2")
        {
            Instantiate(Resources.Load("Gear3"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            same = true;


            //InstantiateObj.isEmpty = false;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }



        if (mouseButtonReleased && this.gameObject.tag == "Wheel" && collision.gameObject.tag == "ResetPos")
        {
            transform.position = StartPos;
        }
        if (mouseButtonReleased && this.gameObject.tag == "Wheel2" && collision.gameObject.tag == "ResetPos")
        {
            transform.position = StartPos;
        }

        if (mouseButtonReleased && this.gameObject.tag == "Tire" && collision.gameObject.tag == "ResetPos")
        {
            transform.position = StartPos;
        }
        if (mouseButtonReleased && this.gameObject.tag == "Tire2" && collision.gameObject.tag == "ResetPos")
        {
            transform.position = StartPos;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (mouseButtonReleased && this.gameObject.tag == "Electric" && collision.gameObject.tag == "ResetPos")
        {
            transform.position = StartPos;
        }
        if (mouseButtonReleased && this.gameObject.tag == "Electric2" && collision.gameObject.tag == "ResetPos")
        {
            transform.position = StartPos;
        }

        if (mouseButtonReleased && this.gameObject.tag == "Gear" && collision.gameObject.tag == "ResetPos")
        {
            transform.position = StartPos;
        }
        if (mouseButtonReleased && this.gameObject.tag == "Gear2" && collision.gameObject.tag == "ResetPos")
        {
            transform.position = StartPos;
        }
    }

    

}
