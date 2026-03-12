using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Rebrickable.Colors.Abstract;

/// <summary>
/// A utility library for color related Rebrickable operations
/// </summary>
public interface IRebrickableColorsUtil
{
    ValueTask<System.IO.Stream?> GetAll(CancellationToken cancellationToken = default);
}
