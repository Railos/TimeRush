using System.Collections;
using UnityEngine;

public class ShootRevolver : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform attackPoint;
    private bool canShoot = true;
    void Update()
    {
        float screenX = Screen.width / 2;
        float screenY = Screen.height / 2;
 
        RaycastHit hit;
        Ray ray = GetComponent<Camera>().ScreenPointToRay(new Vector3(screenX, screenY));
 
        if (Physics.Raycast(ray, out hit))
        {
            attackPoint.transform.LookAt(hit.point);
        }
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            canShoot = false;
            StartCoroutine(waitForShooting());
            GameObject obj = Instantiate(bullet, attackPoint.position,Quaternion.identity);
            obj.GetComponent<Rigidbody>().AddForce(attackPoint.transform.forward * 50f);
        }
    }

    IEnumerator waitForShooting()
    {
        yield return new WaitForSeconds(0.7f);
        canShoot = true;
    }
}
