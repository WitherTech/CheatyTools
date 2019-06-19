using Terraria.ID;
using Terraria.ModLoader;

namespace CheatyTools.Items
{
	public class SuperCheatySword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Cheaty Sword");
			Tooltip.SetDefault("This is a Super Cheaty Sword and should only be used by cheaters.");
		}
		public override void SetDefaults()
		{
			item.damage = 100000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 13;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}
