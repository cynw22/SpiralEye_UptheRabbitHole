using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundFXManager : MonoBehaviour
{
    [SerializeField] private AudioSource soundFxObject;

    private void Awake()
    {
        soundFxObject = GetComponent<AudioSource>();
        if (soundFxObject == null)
        {
            soundFxObject = gameObject.AddComponent<AudioSource>();
            if (soundFxObject == null)
            {
                soundFxObject = gameObject.AddComponent<AudioSource>();
            }
        }
    }

    //play single clip
    public void PlaySound(AudioClip clip, float volume = 1f)
    {
        if (clip == null) return;

        soundFxObject.PlayOneShot(clip, volume);
    }

    //play random clip
    public void PlayRandomSound(AudioClip[] clips, float volume = 1f)
    {
        if (clips == null || clips.Length == 0) return;
        int index = Random.Range(0, clips.Length);
        PlaySound(clips[index], volume);
    }

    public bool IsPlaying()
    {
        return soundFxObject.isPlaying;
    }

    public void Stop()
    {
        soundFxObject.Stop();
    }

    // Start looping a clip
    public void PlayLoop(AudioClip clip)
    {
        if (soundFxObject.clip == clip && soundFxObject.isPlaying) return;
        soundFxObject.clip = clip;
        soundFxObject.loop = true;
        soundFxObject.Play();
    }

    // Stop looping clip
    public void StopLoop()
    {
        soundFxObject.Stop();
        soundFxObject.clip = null;
        soundFxObject.loop = false;
    }
}

