using UnityEngine;
using MelonLoader;

namespace pluggg
{
    public class Main : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F10))
            {
                UnityEngine.Object.FindObjectOfType<PlayerStatus>().hp = 999;
                UnityEngine.Object.FindObjectOfType<PlayerStatus>().maxHp = 999;
                UnityEngine.Object.FindObjectOfType<PlayerStatus>().stamina = 999;
                UnityEngine.Object.FindObjectOfType<PlayerStatus>().maxStamina = 999;
                UnityEngine.Object.FindObjectOfType<PlayerManager>().SetArmor(3,2);
                UnityEngine.Object.FindObjectOfType<LocalPlayer>().SendMessage("test");
            }
            if (Input.GetKeyDown(KeyCode.F9))
            {
                UnityEngine.Object.FindObjectOfType<PlayerManager>().DamagePlayer(1);
            }
            if (Input.GetKeyDown(KeyCode.F8)) {
                UnityEngine.Object.FindObjectOfType<PlayerMovement>().Movement(-999, 999);
                UnityEngine.Object.FindObjectOfType<PowerupInventory>().GetExtraJumps();
            }
            if (Input.GetKeyDown(KeyCode.F7)) {
                UnityEngine.Object.FindObjectOfType<PlayerStatus>().strength = 999;
                UnityEngine.Object.FindObjectOfType<InventoryItem>().attackDamage = 999;
                UnityEngine.Object.FindObjectOfType<InventoryItem>().attackSpeed = 999;
                UnityEngine.Object.FindObjectOfType<InventoryItem>().attackRange = 999;
            }
            if (Input.GetKeyDown(KeyCode.F6)) {

            }

        }
        private void Awake()
        {
            
        }

        public string username;

        public static bool flyMode;
    }
}
