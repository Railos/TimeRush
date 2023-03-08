using UnityEngine;

public class GrabbingObjects : MonoBehaviour
{

    [SerializeField] private Transform holdArea;
    private GameObject heldObj;
    private Rigidbody heldObjRB;

    [SerializeField] private float pickUpRange = 5f;
    [SerializeField] private float pickUpForce = 150f;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (heldObj == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,
                        pickUpRange))
                {
                    PickObj(hit.transform.gameObject);
                }
            }
            else
            {
                DropObj();
            }
        }

        if (heldObj != null)
        {
            MoveObj();
        }

        if (Input.GetMouseButtonDown(1) && heldObj != null)
        {
            DropObj();
            heldObjRB.AddForce(450f * transform.forward);
        }
    }

    private void MoveObj()
    {
        if (Vector3.Distance(heldObj.transform.position, holdArea.position) > 0.05f)
        {
            Vector3 moveDir = holdArea.position - heldObj.transform.position;
            heldObjRB.AddForce(moveDir * pickUpForce);
        }
    }

    private void PickObj(GameObject pickObj)
    {
        if (pickObj.GetComponent<Rigidbody>())
        {
            heldObjRB = pickObj.GetComponent<Rigidbody>();
            heldObjRB.useGravity = false;
            heldObjRB.drag = 6f;
            heldObjRB.constraints = RigidbodyConstraints.FreezeRotation;

            heldObjRB.transform.parent = holdArea;
            heldObj = pickObj;
        }
    }
    
    private void DropObj()
    {
        heldObjRB.useGravity = true;
        heldObjRB.drag = 0f;
        heldObjRB.constraints = RigidbodyConstraints.None;

        heldObjRB.transform.parent = null;
        heldObj = null;
    }
}
