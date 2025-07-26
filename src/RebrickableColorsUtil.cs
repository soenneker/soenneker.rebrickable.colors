using Soenneker.Extensions.Task;
using Soenneker.Extensions.ValueTask;
using Soenneker.Rebrickable.ClientUtil.Abstract;
using Soenneker.Rebrickable.Colors.Abstract;
using Soenneker.Rebrickable.OpenApiClient;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Rebrickable.Colors;

/// <inheritdoc cref="IRebrickableColorsUtil"/>
public sealed class RebrickableColorsUtil: IRebrickableColorsUtil
{
    private readonly IRebrickableClientUtil _clientUtil;

    public RebrickableColorsUtil(IRebrickableClientUtil clientUtil)
    {
        _clientUtil = clientUtil;
    }

    public async ValueTask<System.IO.Stream?> GetAll(CancellationToken cancellationToken = default)
    {
        RebrickableOpenApiClient client = await _clientUtil.Get(cancellationToken).NoSync();

        return await client.Api.V3.Lego.Colors.EmptyPathSegment.GetAsync(null, cancellationToken).NoSync();
    }
}
