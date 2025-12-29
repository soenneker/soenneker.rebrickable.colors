using AwesomeAssertions;
using Soenneker.Facts.Local;
using Soenneker.Rebrickable.Colors.Abstract;
using Soenneker.Tests.FixturedUnit;
using System.IO;
using System.Threading.Tasks;
using Soenneker.Facts.Manual;
using Xunit;

namespace Soenneker.Rebrickable.Colors.Tests;

[Collection("Collection")]
public sealed class RebrickableColorsUtilTests : FixturedUnitTest
{
    private readonly IRebrickableColorsUtil _util;

    public RebrickableColorsUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IRebrickableColorsUtil>(true);
    }

    [Fact]
    public void Default()
    {
    }

    [ManualFact]
    //[LocalFact]
    public async ValueTask GetColors()
    {
        Stream? result = await _util.GetAll(CancellationToken);

        result.Should()
              .NotBeNull();
    }
}