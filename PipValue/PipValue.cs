using System;
using cAlgo.API;
using cAlgo.API.Internals;
using cAlgo.API.Indicators;
using cAlgo.Indicators;

namespace cAlgo
{
    [Indicator(IsOverlay = true, TimeZone = TimeZones.UTC, AccessRights = AccessRights.None)]
    public class PipValue : Indicator
    {
        [Parameter("Vertical Alignment", DefaultValue = VerticalAlignment.Top)]
        public VerticalAlignment VAlignment { get; set; }

        [Parameter("Horizontal Alignment", DefaultValue = HorizontalAlignment.Right)]
        public HorizontalAlignment HAlignment { get; set; }

        [Parameter("Units", DefaultValue = 1000, MinValue = 1000, Step = 1000)]
        public int units { get; set; }

        protected override void Initialize()
        {
            // Initialize and create nested indicators
        }

        public override void Calculate(int index)
        {
            double pipValue = Symbol.PipValue;
            String toShowText = "Pip Value = " + pipValue * units;
            Chart.DrawStaticText("PipValue", toShowText, VAlignment, HAlignment, Color.WhiteSmoke);
        }
    }
}
