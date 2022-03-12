# ColorPlus
A [Grasshopper 3d](https://www.rhino3d.com/6/new/grasshopper/) Plugin that adds a small set of tools for the creation and previewing of color palettes and makes conversion to Hex and OLE web-friendly color formats easy.

[Download the Plugin at Food4Rhino](https://www.food4rhino.com/en/app/color)


## Components
Grasshopper component descriptions

### Preview
Display color swatch and name 
> *Tab : Display* | *Panel : Colour*
 - **Preview Colors** is a utility component that takes a list of colors and displays them as stacked swatches with options to resize each swatch, label it, and add/remove a border.

### Color Space
Converts colors between various common color spaces  
> *Tab : Display* | *Panel : Colour*
 - **ToHex** returns the hex string of an input color.
 - **ToOLE** returns the ole integer of an input color.
 - **FromOLE** returns the color from an ole input.

### Color Space
Converts colors between various common color spaces  
> *Tab : Display* | *Panel : Colour*
 - **Invert** takes a color and subtracts each channel from 255 returning the inverted color
 - Tween Colors takes two input colors and interpolates between their channels based on a unitized parameter, returning the color at the given percent between the source and target color.
 - **Average Colors** takes a list of colors and sums their values then divides the result by the total number of samples returning an averages color.
 - **Construct Gradient** takes a list of colors and an optional matching set of parameters and creates a new gradient from these stops that is then sampled by a unitized input, returning the color at the given parameter
 - **Color Sets** uses the Harmony Library to return lists of colors based on a color input and selection type such as Complementary, Analogous, Triad, Tetradic, and a series of other variations. Harmony Library: https://github.com/aloisdg/Harmony
 - **Color Collections** provides a series of standard color palettes to choose from. Each palette is either pulled from the system or is a pre-populated list from common web and desktop color palettes including Material and D3. Collections with an asterisk (*) before their name have subsets in the collection that filter the results. For example, Material has a range of brightness subsets to choose from. The result is a list of colors and their associated collection names.
 -- Known (From Windows) https://docs.microsoft.com/en-us/dotnet/api/system.drawing.knowncolor?view=net-5.0
 -- System (From Windows) https://docs.microsoft.com/en-us/dotnet/api/system.windows.systemcolors?view=net-5.0
 -- Windows (From Windows) https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.colors?view=net-5.0
 -- Win8 (Preset) https://www.w3schools.com/colors/colors_win8.asp
 -- Metro (Preset) https://materialui.co/metrocolors
 -- Flat (Preset) https://materialui.co/flatuicolors
 -- Fluent (Preset) https://www.fluentcolors.com/
 -- RAL (Preset) https://ral-colors.us/
 -- *Material (SubSets) https://materialui.co/colors/
 -- *Tailwind (SubSets) https://tailwindcolor.com/
 -- *D3 Categorical (SubSets) https://github.com/d3/d3-scale-chromatic
 -- *D3 Sequential Single (SubSets) https://github.com/d3/d3-scale-chromatic
 -- *D3 Sequential Multiple (SubSets) https://github.com/d3/d3-scale-chromatic
 -- *D3 Sequential Spectrum (SubSets) https://github.com/d3/d3-scale-chromatic
 -- *D3 Diverging (SubSets) https://github.com/d3/d3-scale-chromatic
 -- *D3 Cyclical (SubSets) https://github.com/d3/d3-scale-chromatic

## Dependencies

 - [Rhinoceros 3d](https://www.rhino3d.com/)
 - [Rhinocommon](https://www.nuget.org/packages/RhinoCommon/5.12.50810.13095)
 - [Harmony](https://github.com/aloisdg/Harmony)
