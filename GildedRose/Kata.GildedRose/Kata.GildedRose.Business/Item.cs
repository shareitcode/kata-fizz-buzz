namespace Kata.GildedRose.Business
{
	public sealed class Item
	{
		public string Name { get; set; }

		/// <summary>
		/// Nombre de jours restant pour vendre l'article
		/// </summary>
		public int SellIn { get; set; }

		/// <summary>
		/// Dénote combien l'article est précieux
		/// </summary>
		public int Quality { get; set; }

		public override string ToString() => this.Name + ", " + this.SellIn + ", " + this.Quality;

		public void IncrementQuality() => this.Quality++;
		public void DecreaseQuality() => this.Quality--;
		public void DecreaseSellIn() => this.SellIn--;

		public bool QualityIsSmallerThanFifty() => this.Quality < 50;
		public bool SellInIsSmallerThanZero() => this.SellIn < 0;
		public bool QualityIsGreaterThanZero() => this.Quality > 0;
		public bool SellInIsSmallerThanEleven() => this.SellIn < 11;
	}
}