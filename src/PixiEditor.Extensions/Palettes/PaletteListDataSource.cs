﻿using PixiEditor.Extensions.Palettes;
using PixiEditor.Extensions.Palettes.Parsers;
using PixiEditor.Models.IO;

namespace PixiEditor.Models.DataProviders;

public abstract class PaletteListDataSource
{
    public virtual void Initialize() { }

    /// <summary>
    ///     Fetches palettes from the provider.
    /// </summary>
    /// <param name="startIndex">Starting fetch index. Palettes before said index won't be fetched.</param>
    /// <param name="items">Max amount of palettes to fetch.</param>
    /// <param name="filtering">Filtering settings for fetching.</param>
    /// <returns>A List of palettes. Null if fetch wasn't successful.</returns>
    public abstract Task<List<IPalette>> FetchPaletteList(int startIndex, int items, FilteringSettings filtering);
    public List<PaletteFileParser> AvailableParsers { get; set; }
}
