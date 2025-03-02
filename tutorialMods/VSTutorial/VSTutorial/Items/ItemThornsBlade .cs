using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;

namespace VSTutorial.Items
{
    internal class ItemThornsBlade : Item
    {
        public override void OnAttackingWith(IWorldAccessor world, Entity byEntity, Entity attackedEntity, ItemSlot itemslot)
        {
            //api.Logger.Event("Got attack with thorns blade!");

            DamageSource damage = new DamageSource()
            {
                Type = EnumDamageType.PiercingAttack,
                SourceEntity = byEntity,
                KnockbackStrength = 0
            };

            DamageSource healing = new DamageSource()
            {
                Type = EnumDamageType.Heal,
                SourceEntity = byEntity,
                KnockbackStrength = 0
            };

            //byEntity.ReceiveDamage(damage, 0.25f);
            byEntity.ReceiveDamage(healing, 1.0f);

            if (attackedEntity.Alive)
            {
                // take damage on hitting live target
                //byEntity.ReceiveDamage(damage, 0.25f);

                //heal on hit living target
                //byEntity.
            }

            base.OnAttackingWith(world, byEntity, attackedEntity, itemslot);
        }
    }
}
