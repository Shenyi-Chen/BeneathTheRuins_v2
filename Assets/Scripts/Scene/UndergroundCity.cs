using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndergroundCity : MonoBehaviour
{
    public GameObject npc;
    public GameObject dialogue_Symbol;

    public Transform playerSpawnPoint;
    public void Init()
    {
        Hide();
    }

    public void Show() { gameObject.SetActive(true); }
    public void Hide() { gameObject.SetActive(false); }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        // 场景中找到 Player
        PlayerMove player = FindObjectOfType<PlayerMove>();

        if (player != null && playerSpawnPoint != null)
        {
            // ⭐ 直接把玩家传送到出生点
            player.transform.position = playerSpawnPoint.position;
        }
        else
        {
            Debug.LogWarning("没找到 Player 或 playerSpawnPoint 没设置");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
