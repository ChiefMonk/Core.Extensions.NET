using NUnit.Framework;

namespace Core.Extensions.NET.Test;

[TestFixture]
public class DateTimeExtensionsTests
{

	[Test]
	public void Get_FirstDayOfTheMonth_For_2023_10_Success()
	{
		DateTime date = new DateTime(2023, 10, 23);
		var responseDate = date.FirstDayOfTheMonth();

		Assert.That(responseDate, Is.EqualTo(new DateTime(2023, 10, 1)));
	}

	[Test]
	public void Get_FirstDayOfTheMonth_For_2023_10_Fail()
	{
		DateTime date = new DateTime(2023, 10, 26);
		var responseDate = date.FirstDayOfTheMonth();

		Assert.That(new DateTime(2023, 10, 26), Is.Not.EqualTo(responseDate));
		Assert.That(responseDate, Is.EqualTo(new DateTime(2023, 10, 1)));
	}
}

