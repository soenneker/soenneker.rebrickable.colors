using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Rebrickable.Colors.Abstract;

/// <summary>
/// Retrieves LEGO color data from Rebrickable.
/// </summary>
public interface IRebrickableColorsUtil
{
    /// <summary>
    /// Gets the first paginated color-list response as a stream.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The response stream, or <see langword="null"/> when the API returns no content.</returns>
    ValueTask<System.IO.Stream?> GetAll(CancellationToken cancellationToken = default);
}
