using System.Collections.Generic;

namespace Kata.GildedRose.Business
{
	public sealed class GildedRose
	{
		private const string AgedBrie = "Aged Brie";
		private const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
		private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
		public readonly IList<Item> Items;

		public GildedRose(IList<Item> Items)
		{
			this.Items = Items;
		}

		public void UpdateQuality()
		{
			foreach (Item item in Items)
			{
				if (item.Name != AgedBrie && item.Name != BackstagePasses && item.Quality > 0 && item.Name != Sulfuras)
				{
					item.DecreaseQuality();
				}
				else
				{
					if (item.Quality < 50)
					{
						item.IncrementQuality();

						if (item.Name == BackstagePasses && item.SellIn is < 11 or < 6)
						{
							item.IncrementQuality();
						}
					}
				}

				if (item.Name != Sulfuras)
				{
					item.DecreaseSellIn();
				}

				if (item.SellIn < 0)
				{
					if (item.Name == AgedBrie)
					{
						if (item.Quality < 50)
						{
							item.IncrementQuality();
						}
					}
					else if (item.Name == BackstagePasses)
					{
						item.Quality -= item.Quality;
					}
					else if (item.Quality > 0 && item.Name != Sulfuras)
					{
						item.DecreaseQuality();
					}
				}
			}
		}
	}
}
