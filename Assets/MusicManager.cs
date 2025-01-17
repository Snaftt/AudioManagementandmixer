using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public AudioSource msmSource;
    public AudioSource diffusionSource;
    public AudioSource lostTrackSource;

    public Toggle msmToggle;
    public Toggle diffusionToggle;
    public Toggle lostTrackToggle;

    public Slider volumeSlider;

    void Start()
    {
        // Initialize toggle events
        msmToggle.onValueChanged.AddListener(OnMsmToggle);
        diffusionToggle.onValueChanged.AddListener(OnDiffusionToggle);
        lostTrackToggle.onValueChanged.AddListener(OnLostTrackToggle);

        // Initialize volume slider event
        volumeSlider.onValueChanged.AddListener(OnVolumeSlider);
    }

    void OnMsmToggle(bool isOn)
    {
        if (isOn)
        {
            // Stop other sources if playing
            diffusionSource.Stop();
            lostTrackSource.Stop();

            // Untoggle opposing toggles
            diffusionToggle.isOn = false;
            lostTrackToggle.isOn = false;

            // Play MSM source
            msmSource.Play();
        }
        else
        {
            // Stop MSM source if it's playing
            msmSource.Stop();
        }
    }

    void OnDiffusionToggle(bool isOn)
    {
        if (isOn)
        {
            // Stop other sources if playing
            msmSource.Stop();
            lostTrackSource.Stop();

            // Untoggle opposing toggles
            msmToggle.isOn = false;
            lostTrackToggle.isOn = false;

            // Play Diffusion source
            diffusionSource.Play();
        }
        else
        {
            // Stop Diffusion source if it's playing
            diffusionSource.Stop();
        }
    }

    void OnLostTrackToggle(bool isOn)
    {
        if (isOn)
        {
            // Stop other sources if playing
            msmSource.Stop();
            diffusionSource.Stop();

            // Untoggle opposing toggles
            msmToggle.isOn = false;
            diffusionToggle.isOn = false;

            // Play Lost Track source
            lostTrackSource.Play();
        }
        else
        {
            // Stop Lost Track source if it's playing
            lostTrackSource.Stop();
        }
    }

    void OnVolumeSlider(float value)
    {
        // Set volume for all sources
        msmSource.volume = value;
        diffusionSource.volume = value;
        lostTrackSource.volume = value;
    }
}