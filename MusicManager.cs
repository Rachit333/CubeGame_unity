using UnityEngine;
using System.Collections.Generic;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] tracks;
    private AudioSource audioSource;
    private List<int> trackIndices;
    private int currentTrackIndex = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        tracks = new AudioClip[]
        {
            Resources.Load<AudioClip>("track1"),
            Resources.Load<AudioClip>("track2"),
            Resources.Load<AudioClip>("track3"),
            Resources.Load<AudioClip>("track4")
        };

        ShuffleTracks();
        PlayNextTrack();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            PlayNextTrack();
        }
    }

    void ShuffleTracks()
    {
        trackIndices = new List<int>();
        for (int i = 0; i < tracks.Length; i++)
        {
            trackIndices.Add(i);
        }

        for (int i = 0; i < trackIndices.Count; i++)
        {
            int temp = trackIndices[i];
            int randomIndex = Random.Range(i, trackIndices.Count);
            trackIndices[i] = trackIndices[randomIndex];
            trackIndices[randomIndex] = temp;
        }
    }

    void PlayNextTrack()
    {
        int nextTrackIndex = trackIndices[currentTrackIndex];
        audioSource.clip = tracks[nextTrackIndex];
        audioSource.Play();
        currentTrackIndex = (currentTrackIndex + 1) % trackIndices.Count;
    }
}
