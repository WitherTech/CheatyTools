using Terraria;
using Terraria.ModLoader;

namespace CheatyTools.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class SuperCheatyWings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Super Cheaty Wings");
			Tooltip.SetDefault("These are Super Cheaty Wings and should only be used by cheaters.");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = 13;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.wingTimeMax = 100000;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend) {
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration) {
			speed = 9f;
			acceleration *= 2.5f;
		}
	}
}