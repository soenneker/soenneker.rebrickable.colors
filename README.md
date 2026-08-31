[![](https://img.shields.io/nuget/v/soenneker.rebrickable.colors.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.rebrickable.colors/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.rebrickable.colors/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.rebrickable.colors/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.rebrickable.colors.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.rebrickable.colors/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.rebrickable.colors/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.rebrickable.colors/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Rebrickable.Colors

Retrieves Rebrickable's LEGO color-list response through the shared authenticated API client.

## Installation

```bash
dotnet add package Soenneker.Rebrickable.Colors
```

## Configuration

```json
{
  "Rebrickable": {
    "ApiKey": "your-api-key"
  }
}
```

## Usage

```csharp
using Soenneker.Rebrickable.Colors.Abstract;
using Soenneker.Rebrickable.Colors.Registrars;

services.AddRebrickableColorsUtilAsSingleton();

public sealed class ColorImporter
{
    private readonly IRebrickableColorsUtil _colors;

    public ColorImporter(IRebrickableColorsUtil colors)
    {
        _colors = colors;
    }

    public async Task Import(CancellationToken cancellationToken)
    {
        await using Stream? response = await _colors.GetAll(cancellationToken);

        if (response is null)
            return;

        // Deserialize or copy the JSON response here.
    }
}
```

`GetAll` returns the raw response stream and the caller owns that stream. Despite the method name, Rebrickable's list endpoint is paginated; this method retrieves the first response page and does not follow its `next` link automatically.
