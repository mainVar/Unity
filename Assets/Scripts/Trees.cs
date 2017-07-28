using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Trees : MonoBehaviour
{
   

    [SerializeField]
    public static bool bild_time = false;
    // Use this for initialization
    public Text Busy_place;
    RaycastHit _hit;
    float raycastLeigth = 100;
    public static bool end = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Busy")
        {
            menu.CreateObj = false;

            Busy_place.text = ("Место занято");

            //
        }
    }
    private void Update()
    {
        
        if (menu.CreateObj == true)
        {
          
            if ( bild_time == true)
            {
                GameObject _target = GameObject.FindWithTag("Object");
                Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(_ray, out _hit, raycastLeigth))
                {
                    Debug.Log(_hit.collider.name);
                    if (_hit.collider.name == "Earth(Clone)")
                    {
                      
                        //  _target.transform.position= _hit.point;
                        _target.transform.position = Vector3.MoveTowards(_hit.point,
                        new Vector3(Input.mousePosition.x, 0, Input.mousePosition.z),
                        2 * Time.deltaTime);
                        if (end == false)
                        {
                            gameObject.tag = "Busy";
                        }
                        // Vector3 cameraTransform = Camera.main.transform.InverseTransformPoint(0, 0, 0);
                        //     trees1.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
                    }
                }
                Debug.DrawRay(_ray.origin, _ray.direction * raycastLeigth, Color.red);
            }
        }
    }

}
