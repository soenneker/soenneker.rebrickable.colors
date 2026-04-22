using AwesomeAssertions;
using Soenneker.Tests.Attributes.Local;
using Soenneker.Rebrickable.Colors.Abstract;
using Soenneker.Tests.HostedUnit;
using System.IO;
using System.Threading.Tasks;
using Soenneker.Facts.Manual;

namespace Soenneker.Rebrickable.Colors.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class RebrickableColorsUtilTests : HostedUnitTest
{
    private readonly IRebrickableColorsUtil _util;

    public RebrickableColorsUtilTests(Host host) : base(host)
    {
        _util = Resolve<IRebrickableColorsUtil>(true);
    }

    [Test]
    public void Default()
    {
    }

    [ManualFact]
    //[LocalOnly]
    public async ValueTask GetColors()
    {
        Stream? result = await _util.GetAll(CancellationToken);

        result.Should()
              .NotBeNull();
    }
}