using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuEvents : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;
    private float value;
    private void Start()
    {
        mixer.GetFloat("masterVolume", out value);
        volumeSlider.value = value;
    }
    public void SetVolume()
    {
        mixer.SetFloat("masterVolume", volumeSlider.value);
    }
    
    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}
