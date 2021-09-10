using UnityEngine;
public class Clientt : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
        }
    }
}
