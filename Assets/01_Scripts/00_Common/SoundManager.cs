using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SFX
{
    ButtonClick,
    BreakBlock,
    Coin,
    FireBall,
    GameOver,
    Hit,
    ScoreUp,
    Warning,
}

public class SoundManager : Singleton<SoundManager>
{
    public AudioSource bgmAudioSource;
    public AudioSource sfxAudioSource;

    public AudioClip bgmAudioClip;
    public List<AudioClip> sfxAudioClips;

    private void Start()
    {

        if (bgmAudioSource == null)
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

    public void StopBGM()
    {
        bgmAudioSource.Stop();
    }

    public void PlaySFX(SFX sfx, float volume = 1.0f, float time = 0.0f)
    {
        sfxAudioSource.volume = volume;
        StartCoroutine(PlaySFX(sfxAudioClips[(int)sfx], time));
    }

    private IEnumerator PlaySFX(AudioClip audio, float time)
    {
        yield return new WaitForSeconds(time);
        sfxAudioSource.PlayOneShot(audio);
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
