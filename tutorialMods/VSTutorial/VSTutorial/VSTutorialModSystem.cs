using Vintagestory.API.Client;
using Vintagestory.API.Server;
using Vintagestory.API.Config;
using Vintagestory.API.Common;
using VSTutorial.Blocks;
using VSTutorial.Items;

namespace VSTutorial;

public class VSTutorialModSystem : ModSystem
{

    // Called on server and client
    // Useful for registering block/entity classes on both sides
    public override void Start(ICoreAPI api)
    {
        api.RegisterBlockClass($"{Mod.Info.ModID}.trampoline", typeof(BlockTrampoline));
        api.RegisterItemClass($"{Mod.Info.ModID}.thornsblade", typeof(ItemThornsBlade));
        //Mod.Logger.Notification("Hello from template mod: " + api.Side);
    }

    //public override void StartServerSide(ICoreServerAPI api)
    //{
    //    Mod.Logger.Notification($"Hello from template mod server side: {Lang.Get("vstutorial:hello")}");
    //}

    //public override void StartClientSide(ICoreClientAPI api)
    //{
    //    Mod.Logger.Notification($"Hello from template mod client side: {Lang.Get("vstutorial:hello")}");
    //}

}
