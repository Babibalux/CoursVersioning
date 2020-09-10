using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LETRUKOUYAPLEINDELETTRESETOUTAVU : MonoBehaviour
{
    public Vector3 vector;
    public bool reboot;
    public float speedMax;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(reboot == true)
        {
            StartCoroutine("KubKiBouj");
        }
        this.transform.Translate(vector);
    }

    IEnumerator KubKiBouj()
    {
        reboot = false;
        vector = new Vector3(Random.Range(-speedMax, speedMax), Random.Range(-speedMax, speedMax), Random.Range(-speedMax, speedMax));
        yield return new WaitForSeconds(0.5f);
        reboot = true;
    }
}
