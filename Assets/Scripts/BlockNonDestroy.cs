using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockNonDestroy : MonoBehaviour
{

    public float xPos;
    public float yPos;
    public float zPos;

    IEnumerator OnTriggerEnter(Collider col)
    {
        transform.GetComponent<Collider>().isTrigger = false;
        if (col.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(xPos, yPos + 0.2F, zPos);
            yield return new WaitForSeconds(0.08F);
            this.transform.position = new Vector3(xPos, yPos, zPos);
            yield return new WaitForSeconds(0.25F);
            transform.GetComponent<Collider>().isTrigger = true;
        }
    }

    // Use this for initialization
    void Start()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;
        zPos = transform.position.z;
    }


}