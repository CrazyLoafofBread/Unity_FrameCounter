using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameCounter : MonoBehaviour
{
    [SerializeField]private float TimeToRefresh = 0.5f;
    private int frames;
    private float TimeCounter;
    private float fps;

    private void Update()
    {
        if(TimeCounter < TimeToRefresh)
        {
            TimeCounter += Time.deltaTime;
            frames++;
        }
        else
        {
            fps = frames / TimeCounter;
            frames = 0;
            TimeCounter = 0f;
        }
    }

    private void OnGUI()
    {
        GUI.Label(position: new Rect(x: 100, y: 100, width: 200, height: 120), text: $"FPS: {fps}");
    }
}
