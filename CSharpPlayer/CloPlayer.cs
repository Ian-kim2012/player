using System;

namespace CSharpPlayer
{
	/// <summary>
	/// sample player 입니다. 이 클래스에 추가 작성해도 좋고 별도의 프로젝트에 다시 작성해도 무방합니다.
	/// <para>필수 메서드 GetName(), Initialize(), MoveNext()의 접근제한자를 public 으로 지정해주세요.</para>
	/// </summary>
	public class CloPlayer
	{
		private int _myNumber;
		private int _column;
		private int _row;

		public string GetName()
		{
			return "c# player";
		}

		public void Initialize(int myNumber, int column, int row)
		{
			_myNumber = myNumber;
			_column = column;
			_row = row;
		}

		public int MoveNext(int[] map, int myPosition)
		{
			var random = new Random();
			var direction = random.Next(4);
			return direction;
		}
	}
}
