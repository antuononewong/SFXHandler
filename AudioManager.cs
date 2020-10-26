using UnityEngine;

/* Simple single script handler for sound effects. All that's needed is to 
*place sound files into the Resources folder of the project. Create a variable
 * to store x sound file. Then add a switch case for it, so it can be found when
 * the sound effect needs to be played. Prevents having to store individual sound effects
 * in the corresponding script that needs them.
 */

public class SFXHandler : MonoBehaviour
{
    private static AudioClip _borkSound, _enemyWolfSpawnSound, _enemyWolfDeathSound, _enemyDeathSound;

    private static AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();

        _borkSound = Resources.Load<AudioClip>("Bork");
        _enemyWolfSpawnSound = Resources.Load<AudioClip>("EnemyWolfSpawn");
        _enemyWolfDeathSound = Resources.Load<AudioClip>("EnemyWolfDeath");
        _enemyDeathSound = Resources.Load<AudioClip>("EnemyDeath");
    }

    // Used when a sound clip is needed by some other gameObject
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Bork":
                _audioSource.PlayOneShot(_borkSound);
                break;
            case "EnemyWolfSpawn":
                _audioSource.PlayOneShot(_enemyWolfSpawnSound);
                break;
            case "EnemyWolfDeath":
                _audioSource.PlayOneShot(_enemyWolfDeathSound);
                break;
            case "EnemyDeath":
                _audioSource.PlayOneShot(_enemyDeathSound);
                break;

        }
    }
}
