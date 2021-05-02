using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Kata.GildedRose.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.GildedRose.Tests
{
	[TestClass]
	public class GildedRoseTests
	{
		private IList<Item> ItemsGolden;
		private IList<Item> Items;
		private GildedRoseGolderMaster gildedRoseGolden;
		private Business.GildedRose gildedRose;

		[TestInitialize]
		public void InitItems()
		{
			this.Items = new List<Item>{
					new() { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
					new() { Name = "Aged Brie", SellIn = 2, Quality = 0 },
					new() { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
					new() { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
					new() { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
					new()
					{
						Name = "Backstage passes to a TAFKAL80ETC concert",
						SellIn = 15,
						Quality = 20
					},
					new()
					{
						Name = "Backstage passes to a TAFKAL80ETC concert",
						SellIn = 10,
						Quality = 49
					},
					new()
					{
						Name = "Backstage passes to a TAFKAL80ETC concert",
						SellIn = 5,
						Quality = 49
					},
					// this conjured item does not work properly yet
					new() { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
			};
			this.ItemsGolden = new List<Item>{
					new() { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
					new() { Name = "Aged Brie", SellIn = 2, Quality = 0 },
					new() { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
					new() { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
					new() { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
					new()
					{
							Name = "Backstage passes to a TAFKAL80ETC concert",
							SellIn = 15,
							Quality = 20
					},
					new()
					{
							Name = "Backstage passes to a TAFKAL80ETC concert",
							SellIn = 10,
							Quality = 49
					},
					new()
					{
							Name = "Backstage passes to a TAFKAL80ETC concert",
							SellIn = 5,
							Quality = 49
					},
					// this conjured item does not work properly yet
					new() { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
			};

			this.gildedRoseGolden = new(this.ItemsGolden);
			this.gildedRose = new(this.Items);

			for (int i = 0; i < 31; i++)
			{
				this.gildedRoseGolden.UpdateQuality();
				this.gildedRose.UpdateQuality();
			}
		}

		[TestMethod]
		public void ShouldBeTheInitialeResult()
		{
			string itemsGolden = this.BuildStringItems(this.gildedRoseGolden.Items);
			string items = this.BuildStringItems(this.gildedRose.Items);

			this.gildedRose.Items.Should().BeEquivalentTo(this.gildedRoseGolden.Items);
			items.Should().BeEquivalentTo(itemsGolden);
		}

		private string BuildStringItems(IList<Item> items)
		{
			StringBuilder stringBuilder = new();

			foreach (Item item in items)
			{
				stringBuilder.AppendLine(item.ToString());
			}

			return stringBuilder.ToString();
		}
	}
}