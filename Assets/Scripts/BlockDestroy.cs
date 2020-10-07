using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    public float xPos;
    public float yPos;
    public float zPos;
    float waiting = 0.02F;

    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(xPos, yPos + 0.1F, zPos);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos + 0.2F, zPos);
            yield return new WaitForSeconds(waiting);
            transform.GetComponent<Collider>().isTrigger = false;
            this.transform.position = new Vector3(xPos, yPos + 0.3F, zPos + 0.5F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos + 0.4F, zPos + 1.0F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos - 0.1F, zPos + 1.5F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos - 0.6F, zPos + 2.0F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos - 1.6F, zPos + 2.0F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos - 2.6F, zPos + 2.0F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos - 4.0F, zPos + 2.0F);
            yield return new WaitForSeconds(0.25F);
            transform.GetComponent<Collider>().isTrigger = true;
            Destroy(gameObject);
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