using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Rebrickable.Colors.Abstract;

/// <summary>
/// A utility library for color related Rebrickable operations
/// </summary>
public interface IRebrickableColorsUtil
{
    /// <summary>
    /// Gets all.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<System.IO.Stream?> GetAll(CancellationToken cancellationToken = default);
}
