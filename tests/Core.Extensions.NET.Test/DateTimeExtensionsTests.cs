using Xunit;

namespace Core.Extensions.NET.Test;

public class DateTimeExtensionsTests
{

	[Fact]
	public void Get_FirstDayOfTheMonth_For_2023_10_Success()
	{
		DateTime date = new DateTime(2023, 10, 23);
		var responseDate = date.FirstDayOfTheMonth();

		Assert.Equal(new DateTime(2023, 10, 1), responseDate);
	}

	[Fact]
	public void Get_FirstDayOfTheMonth_For_2023_10_Fail()
	{
		DateTime date = new DateTime(2023, 10, 26);
		var responseDate = date.FirstDayOfTheMonth();

		Assert.NotEqual(new DateTime(2023, 10, 26), responseDate);
		Assert.Equal(new DateTime(2023, 10, 1), responseDate);
	}
}

