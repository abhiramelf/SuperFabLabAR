using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private DefaultTrackableEventHandler eventHandler;

    void Awake()
    {
        //infoCanvas.SetActive(false);
        eventHandler = this.gameObject.GetComponent<DefaultTrackableEventHandler>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VideoPlayZund()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=sEBS8L1pKrQ&t=48s");
    }

    public void VideoPlayLathe()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=GX9eRa-h3tY");
    }

    public void VideoPlayOmax()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=mDDcOPsrTIk");
    }

    public void VideoPlayLaser()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=DNh2SjkWNnk");
    }

    public void VideoPlayPrusa()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=hwNIzQLtHnU");
    }

    public void VideoPlaySindoh()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=d7Jetk3gJPY");
    }

    public void ResetPlay()
    {
        eventHandler.OnTrackingLost();
    }

}
