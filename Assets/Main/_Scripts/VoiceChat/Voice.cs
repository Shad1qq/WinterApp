using UnityEngine;

public class Voice : MonoBehaviour
{
    private AudioSource _source;
    private int _sampleWindow = 64;
    private void Awake()
    {
        _source = GetComponent<AudioSource>();
        foreach(string nameMic in Microphone.devices)
        {
            Debug.Log(nameMic);
        }
        _source.clip = Microphone.Start(null, true, 1, AudioSettings.outputSampleRate);

        _source.enabled = false;
    }
    private void Start()
    {
        _source.enabled = true;
    }
}
