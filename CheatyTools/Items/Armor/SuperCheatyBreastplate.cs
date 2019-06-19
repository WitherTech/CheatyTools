using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CheatyTools.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class SuperCheatyBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Super Cheaty Breastplate");
			Tooltip.SetDefault("This is a Super Cheaty Breastplate and should only be used by cheaters."
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