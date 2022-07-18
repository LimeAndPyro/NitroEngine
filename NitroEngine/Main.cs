using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using NitroEngine;

[assembly: MelonInfo(typeof(NitroMain), "Nitro Engine", "1", "Scrim")]
[assembly: MelonGame("VRChat", "VRChat")]
[assembly: MelonColor(ConsoleColor.Blue)]

namespace NitroEngine
{
    public class NitroMain : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonCoroutines.Start(OnVRCUI());
            MelonCoroutines.Start(OnGameInit());
        }

        public override void OnUpdate()
        {
            
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {

        }
         public IEnumerator OnGameInit() 
        { 
            while (GameObject.Find("UserInterface") == null) yield return null;
            GameInit();
            yield break;
        }

        public void GameInit()
        {
            
            
        }
        //
        public IEnumerator OnVRCUI()
        {
            while (GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)") == null) yield return null; //If Qm Exists
            new WaitForSeconds(0.7f);//Waits to Prevent Breakage
            UIIsInit();//Calls UI Changes
            yield break;//Breaks Statement
        }
        //
        public void UIIsInit()
        {
           
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            
        }

        public override void OnApplicationQuit()
        {
            
        }
        
    }
}
