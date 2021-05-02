using System.Collections.Generic;

namespace Kata.GildedRose.Business
{
	public sealed class GildedRose
	{
		private const string AgedBrie = "Aged Brie";
		private const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
		private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
		public readonly IList<Item> Items;

		public GildedRose(IList<Item> Items) => this.Items = Items;

		public void UpdateQuality()
		{
			foreach (Item item in this.Items)
			{
				if (item.Name != AgedBrie && item.Name != BackstagePasses && item.QualityIsGreaterThanZero() && item.Name != Sulfuras)
				{
					item.DecreaseQuality();
				}
				else
				{
					if (item.QualityIsSmallerThanFifty())
					{
						item.IncrementQuality();

						if (item.Name == BackstagePasses && item.SellInIsSmallerThanEleven())
						{
							item.IncrementQuality();
						}
					}
				}

				if (item.Name != Sulfuras)
				{
					item.DecreaseSellIn();
				}

				if (item.SellInIsSmallerThanZero())
				{
					if (item.Name == AgedBrie)
					{
						if (item.QualityIsSmallerThanFifty())
						{
							item.IncrementQuality();
						}
					}
					else if (item.Name == BackstagePasses)
					{
						item.Quality -= item.Quality;
					}
					else if (item.QualityIsGreaterThanZero() && item.Name != Sulfuras)
					{
						item.DecreaseQuality();
					}
				}
			}
		}
	}
}
