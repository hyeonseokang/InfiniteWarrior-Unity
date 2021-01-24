using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SFX
{
    ButtonClick,
}

public class SoundManager : Singleton<SoundManager>
{
    public AudioSource bgmAudioSource;
    public AudioSource sfxAudioSource;

    public AudioClip bgmAudioClip;
    public List<AudioClip> sfxAudioClips;

    private void Start()
    {
        if(bgmAudioSource == null)
        {
            bgmAudioSource = CreateAudioSource("bgmAudioSource");
            bgmAudioSource.loop = true;
        }
        if(sfxAudioSource == null)
        {
            sfxAudioSource = CreateAudioSource("sfxAudioSource");
            sfxAudioSource.playOnAwake = false;
            sfxAudioSource.loop = false;
        }
    }

    private AudioSource CreateAudioSource(string name)
    {
        GameObject audiosource = new GameObject("bgmAudioSource");
        audiosource.transform.SetParent(transform);

        return audiosource.AddComponent<AudioSource>();
    }

    public void PlayBGM()
    {
        bgmAudioSource.clip = bgmAudioClip;
        bgmAudioSource.Play();
    }

    public void PlaySFX(SFX sfx)
    {
        sfxAudioSource.PlayOneShot(sfxAudioClips[(int)sfx]);
    }

    public void SetMuteBGM(bool isMute)
    {
        bgmAudioSource.mute = isMute;
    }

    public void SetMuteSFX(bool isMute)
    {
        sfxAudioSource.mute = isMute;
    }
}
