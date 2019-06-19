using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CheatyTools.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SuperCheatyHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Super Cheaty Helmet");
			Tooltip.SetDefault("This is a Super Cheaty Helmet and should only be used by cheaters."
				+ "\n+400 max Life");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 13;
			item.defense = 100000;
		}
		
		public override void UpdateEquip(Player player) {
			player.statLifeMax2 += 400;
		}
	}
}