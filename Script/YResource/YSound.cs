using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YLibrary
{

    public class YSound : YScript
    {

        public AudioSource m_bgSource;
        public List<AudioSource> m_sfxSource;

        public Dictionary<string, AudioClip> Pool;

        const string basePath = "Sound/";

        private void Awake()
        {

            m_sfxSource = new List<AudioSource>();
            Pool = new Dictionary<string, AudioClip>();

            m_bgSource = gameObject.AddComponent<AudioSource>();

            SubscribeOnDestory(OnDestroy);

        }

        private void OnDestroy()
        {

            m_sfxSource.Clear();
            Pool.Clear();

        }

        public AudioClip GetSound(string path)
        {

            if (Pool.ContainsKey(path)) Pool[path] = Resources.Load(basePath + path) as AudioClip;

            return Pool[path];

        }

        public bool GetBackgrounPlaying() { return m_bgSource.isPlaying; }

        public void BackgroundStop() => m_bgSource.Stop();

        public void BackgroundPause() => m_bgSource.Pause();
        public void BackgroundUnPause() => m_bgSource.UnPause();

        public void SetBackground(AudioClip clip) => m_bgSource.clip = clip;
        public void SetBackground(string path) => m_bgSource.clip = GetSound(path);

        public void BackgroundRun(AudioClip clip)
        {

            m_bgSource.Play();

            if (m_bgSource.clip == clip) return;

            SetBackground(clip);

        }

        public void BackgroundRun(string path) => BackgroundRun(GetSound(path));

        public void SFXRun(AudioClip clip)
        {

            AudioSource source = gameObject.AddComponent<AudioSource>();

            source.clip = clip;

            source.Play();

            m_sfxSource.Add(source);

        }

        public void SFXRun(string path) => SFXRun(GetSound(path));

    }

}
