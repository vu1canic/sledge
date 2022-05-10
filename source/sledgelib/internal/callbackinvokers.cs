using System;
using System.Collections.Generic;
using System.Reflection;

namespace SledgeLib
{
    internal delegate void dStateChangeCallback(EGameState state);
    internal delegate void dStringCallback(string s);
    internal delegate void dFloatCallback(float f);
    internal delegate void dCallback();

    internal class CallbackInvokers
    {
        internal static CallbackInvokersInterface Interface = new CallbackInvokersInterface();
        internal static CallbackInvokersInterface GetCallbackInvokers()
        {
            Interface.StateChange = OnStateChange;
            Interface.LevelLoad = OnLevelLoad;
            Interface.PreUpdate = OnPreUpdate;
            Interface.PostUpdate = OnPostUpdate;
            Interface.PrePlayerUpdate = OnPrePlayerUpdate;
            Interface.PostPlayerUpdate = OnPostPlayerUpdate;
            Interface.QuickSave = OnQuickSave;
            Interface.QuickLoad = OnQuickLoad;
            return Interface;
        }

        static void InvokeCallbacks(ref List<MethodInfo> CallbackList, object[]? Arguments)
        {
            foreach (MethodInfo CallbackMethod in CallbackList)
            {
                try
                {
                    CallbackMethod.Invoke(null, Arguments);
                }
                catch (Exception e)
                {
                    Log.Error("Error ocurred while invoking callback: {0}", e);
                    lock (CallbackList) { CallbackList.Remove(CallbackMethod); }
                }
            }
        }

        static internal List<MethodInfo> StateChangeCallbacks = new List<MethodInfo>();
        static void OnStateChange(EGameState eState)
        {
            InvokeCallbacks(ref StateChangeCallbacks, new object[] { eState } );
        }

        static internal List<MethodInfo> LevelLoadCallbacks = new List<MethodInfo>();
        static void OnLevelLoad(string sLevelPath)
        {
            InvokeCallbacks(ref LevelLoadCallbacks, new object[] { sLevelPath });
        }

        static internal List<MethodInfo> PreUpdateCallbacks = new List<MethodInfo>();
        static void OnPreUpdate()
        {
            InvokeCallbacks(ref PreUpdateCallbacks, null);
        }

        static internal List<MethodInfo> PostUpdateCallbacks = new List<MethodInfo>();
        static void OnPostUpdate()
        {
            InvokeCallbacks(ref PostUpdateCallbacks, null);
        }

        static internal List<MethodInfo> PrePlayerUpdateCallbacks = new List<MethodInfo>();
        static void OnPrePlayerUpdate(float TimeStep)
        {
            InvokeCallbacks(ref PrePlayerUpdateCallbacks, new object[] { TimeStep });
        }

        static internal List<MethodInfo> PostPlayerUpdateCallbacks = new List<MethodInfo>();
        static void OnPostPlayerUpdate(float TimeStep)
        {
            InvokeCallbacks(ref PostPlayerUpdateCallbacks, new object[] { TimeStep });
        }

        static internal List<MethodInfo> QuickSaveCallbacks = new List<MethodInfo>();
        static void OnQuickSave()
        {
            InvokeCallbacks(ref QuickSaveCallbacks, null);
        }

        static internal List<MethodInfo> QuickLoadCallbacks = new List<MethodInfo>();
        static void OnQuickLoad()
        {
            InvokeCallbacks(ref QuickLoadCallbacks, null);
        }
    }
}