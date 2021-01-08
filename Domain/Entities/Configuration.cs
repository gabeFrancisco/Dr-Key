using Domain.Enums;
using System;

namespace Domain.Entities
{
    [Serializable]
    public class Configuration
    {
        public Theme Theme { get; set; }
        public string Color { get; set; }
        public float FontSize { get; set; }
        public bool ShowId { get; set; } = true;
        public bool ShowManufactor { get; set; } = true;
        public bool ShowModel { get; set; } = true;
        public bool ShowType { get; set; } = true;
        public bool ShowYear { get; set; } = true;
        public bool ShowPrice { get; set; } = true;
        public bool ShowButtons { get; set; } = true;
        public bool ShowService { get; set; }
        public bool ShowQuantity { get; set; } = true;

        public Configuration() { }
        public Configuration(Theme theme, string color, float fontSize)
        {
            Theme = theme;
            Color = color;
            FontSize = fontSize;
        }

        public Configuration(Theme theme, string color, float fontSize, bool showId, bool showManufactor, bool showModel, bool showType, bool showYear, bool showPrice, bool showButtons, bool showService, bool showQuantity) : this(theme, color, fontSize)
        {
            ShowId = showId;
            ShowManufactor = showManufactor;
            ShowModel = showModel;
            ShowType = showType;
            ShowYear = showYear;
            ShowPrice = showPrice;
            ShowButtons = showButtons;
            ShowService = showService;
            ShowQuantity = showQuantity;
        }
    }
}
