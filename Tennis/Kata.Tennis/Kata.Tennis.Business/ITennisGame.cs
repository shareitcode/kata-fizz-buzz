namespace Kata.Tennis.Business
{
	public interface ITennisGame
	{
		void WonPoint(string playerName);
		string GetScore();
	}
}