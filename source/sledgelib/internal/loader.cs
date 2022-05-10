using SledgeLib;
using System;

internal class Loader
{
    public delegate UnmanagedInterface dGetInterface();
    internal static UnmanagedInterface Interface = new UnmanagedInterface();
    public static UnmanagedInterface GetInterface()
    {
        Interface.Init = Loader.Init;
        Interface.Shutdown = Loader.Shutdown;
        Interface.GetCallbackInterface = CallbackInvokers.GetCallbackInvokers;
        Interface.AllocString = Interop.AllocString;
        Interface.LuaFunctionWrapper = LuaFunctionManager.FunctionWrapper;
        return Interface;
    }

    public static bool Init()
    {
        Log.General("Initializing mod manager");
        try { ModManager.Init(); } catch (Exception e) { Log.Error("Error while initializing the mod manager: {0}", e); }

        Log.General("Initializing lua");
        try { Lua.Init(); } catch (Exception e) { Log.Error("Error while initializing Lua: {0}", e); }


        Log.General("Sledgelib successfully loaded");
        return true;
    }

    public static bool Shutdown()
    {
        Log.General("Unloading mods");
        try { ModManager.Shutdown(); } catch (Exception ex) { Log.Error("Error while invoking ModManager.Shutdown: {0}", ex); };

        Log.General("SledgeLib successfully unloaded");
        return true;
    }
}