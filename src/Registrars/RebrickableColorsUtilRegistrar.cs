using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Rebrickable.ClientUtil.Registrars;
using Soenneker.Rebrickable.Colors.Abstract;

namespace Soenneker.Rebrickable.Colors.Registrars;

/// <summary>
/// A utility library for color related Rebrickable operations
/// </summary>
public static class RebrickableColorsUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IRebrickableColorsUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddRebrickableColorsUtilAsSingleton(this IServiceCollection services)
    {
        services.AddRebrickableClientUtilAsSingleton().TryAddSingleton<IRebrickableColorsUtil, RebrickableColorsUtil>();
        return services;
    }

    /// <summary>
    /// Adds <see cref="IRebrickableColorsUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddRebrickableColorsUtilAsScoped(this IServiceCollection services)
    {
        services.AddRebrickableClientUtilAsSingleton().TryAddScoped<IRebrickableColorsUtil, RebrickableColorsUtil>();
        return services;
    }
}
