using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace VSTutorial.Blocks
{
    internal class BlockTrampoline : Block
    {
        public override void OnEntityCollide(IWorldAccessor world, Entity entity, BlockPos pos, BlockFacing facing, Vec3d collideSpeed, bool isImpact)
        {
            base.OnEntityCollide(world, entity, pos, facing, collideSpeed, isImpact);

            if (isImpact && facing.IsVertical)
            {
                float motion = -0.8f;
                entity.Pos.Motion.Y *= motion;
            }
        }
    }
}