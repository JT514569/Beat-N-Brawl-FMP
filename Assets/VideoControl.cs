using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    public string url;
    VideoPlayer vidplayer;
    // Start is called before the first frame update
    void Start()
    {
        vidplayer = GetComponent<VideoPlayer>();
        vidplayer.url = url;
        Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Play()
    {
        vidplayer.Play();
        vidplayer.isLooping = true;
    }
}
