using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{

    public GameObject loader;
    public SceneControl sceneControl;

    private bool isLoaderShownOnce;
    private string videoURL;
    private VideoPlayer videoPlayer;

    private void Start()
    {
        isLoaderShownOnce = false;

        videoURL = Application.streamingAssetsPath;
        videoPlayer = GetComponent<VideoPlayer>();

        sceneControl.CheckCurrentSceneStarted();
    }

    private void Update()
    {
        if (!isLoaderShownOnce)
        {
            loader.SetActive(!videoPlayer.isPlaying);
        }
        
        if (videoPlayer.isPlaying)
        {
            isLoaderShownOnce = true;
            return;
        }
    }

    public void StopVideo()
    {
        videoPlayer.Stop();
    }

    public void PlayVideo(string filename)
    {
        videoPlayer.url = Path.Combine(videoURL, filename);
        videoPlayer.Play();
        videoPlayer.loopPointReached += CheckIfVideoFinished;
    }

    private void CheckIfVideoFinished(VideoPlayer vp)
    {
        sceneControl.CheckCurrentSceneFinished();
    }

}
