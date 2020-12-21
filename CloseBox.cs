using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBox : MonoBehaviour
{
    public GameObject BoxMsg;
    public static CloseBox BoxDialg;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Close()
    {
        BoxMsg.SetActive(false);
    }
    public void OpenBox()
    {
        BoxMsg.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
