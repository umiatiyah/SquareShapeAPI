using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SquareShapeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColorController : ControllerBase
    {
        private readonly ILogger<ColorController> _logger;

        public ColorController(ILogger<ColorController> logger)
        {
            _logger = logger;
        }

        [HttpPost("changeColor")]
        public ActionResult ChangeColor([FromBody] string color)
        {
            bool isColor = false;
			if (Array.Exists(ColorNames, name => name.ToLower() == color.ToLower()))
				isColor = true;

            if (isColor)
            {
                string message = $"Color successfully changed to `{color}`";
                return Ok(message);
            }
            else
            {
                string message = $"Color can not changed to `{color}`, `{color}` not correct color name";
                return BadRequest(message);
            }
        }

		static internal string[] ColorNames = {
			"ActiveBorder",
			"ActiveCaption",
			"ActiveCaptionText",
			"AppWorkspace",
			"Control",
			"ControlDark",
			"ControlDarkDark",
			"ControlLight",
			"ControlLightLight",
			"ControlText",
			"Desktop",
			"GrayText",
			"Highlight",
			"HighlightText",
			"HotTrack",
			"InactiveBorder",
			"InactiveCaption",
			"InactiveCaptionText",
			"Info",
			"InfoText",
			"Menu",
			"MenuText",
			"ScrollBar",
			"Window",
			"WindowFrame",
			"WindowText",
			"Transparent",
			"AliceBlue",
			"AntiqueWhite",
			"Aqua",
			"Aquamarine",
			"Azure",
			"Beige",
			"Bisque",
			"Black",
			"BlanchedAlmond",
			"Blue",
			"BlueViolet",
			"Brown",
			"BurlyWood",
			"CadetBlue",
			"Chartreuse",
			"Chocolate",
			"Coral",
			"CornflowerBlue",
			"Cornsilk",
			"Crimson",
			"Cyan",
			"DarkBlue",
			"DarkCyan",
			"DarkGoldenrod",
			"DarkGray",
			"DarkGreen",
			"DarkKhaki",
			"DarkMagenta",
			"DarkOliveGreen",
			"DarkOrange",
			"DarkOrchid",
			"DarkRed",
			"DarkSalmon",
			"DarkSeaGreen",
			"DarkSlateBlue",
			"DarkSlateGray",
			"DarkTurquoise",
			"DarkViolet",
			"DeepPink",
			"DeepSkyBlue",
			"DimGray",
			"DodgerBlue",
			"Firebrick",
			"FloralWhite",
			"ForestGreen",
			"Fuchsia",
			"Gainsboro",
			"GhostWhite",
			"Gold",
			"Goldenrod",
			"Gray",
			"Green",
			"GreenYellow",
			"Honeydew",
			"HotPink",
			"IndianRed",
			"Indigo",
			"Ivory",
			"Khaki",
			"Lavender",
			"LavenderBlush",
			"LawnGreen",
			"LemonChiffon",
			"LightBlue",
			"LightCoral",
			"LightCyan",
			"LightGoldenrodYellow",
			"LightGray",
			"LightGreen",
			"LightPink",
			"LightSalmon",
			"LightSeaGreen",
			"LightSkyBlue",
			"LightSlateGray",
			"LightSteelBlue",
			"LightYellow",
			"Lime",
			"LimeGreen",
			"Linen",
			"Magenta",
			"Maroon",
			"MediumAquamarine",
			"MediumBlue",
			"MediumOrchid",
			"MediumPurple",
			"MediumSeaGreen",
			"MediumSlateBlue",
			"MediumSpringGreen",
			"MediumTurquoise",
			"MediumVioletRed",
			"MidnightBlue",
			"MintCream",
			"MistyRose",
			"Moccasin",
			"NavajoWhite",
			"Navy",
			"OldLace",
			"Olive",
			"OliveDrab",
			"Orange",
			"OrangeRed",
			"Orchid",
			"PaleGoldenrod",
			"PaleGreen",
			"PaleTurquoise",
			"PaleVioletRed",
			"PapayaWhip",
			"PeachPuff",
			"Peru",
			"Pink",
			"Plum",
			"PowderBlue",
			"Purple",
			"Red",
			"RosyBrown",
			"RoyalBlue",
			"SaddleBrown",
			"Salmon",
			"SandyBrown",
			"SeaGreen",
			"SeaShell",
			"Sienna",
			"Silver",
			"SkyBlue",
			"SlateBlue",
			"SlateGray",
			"Snow",
			"SpringGreen",
			"SteelBlue",
			"Tan",
			"Teal",
			"Thistle",
			"Tomato",
			"Turquoise",
			"Violet",
			"Wheat",
			"White",
			"WhiteSmoke",
			"Yellow",
			"YellowGreen",
			"ButtonFace",
			"ButtonHighlight",
			"ButtonShadow",
			"GradientActiveCaption",
			"GradientInactiveCaption",
			"MenuBar",
			"MenuHighlight"
		};
	}
}
