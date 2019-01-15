using System.Windows;
using ThinkGeo.MapSuite.Wpf;

namespace NauticalChartsViewer
{
    internal class WorldMapShowingMenuItemMessageHandler : MenuItemMessageHandler
    {
        private const string thinkGeoCloudMapsOverlayName = "ThinkGeoCloudMapsOverlay";

        public override void Handle(Window owner, WpfMap map, MenuItemMessage message)
        {
            ThinkGeoCloudMapsOverlay backgroundOverlay;
            if (map.Overlays.Contains(thinkGeoCloudMapsOverlayName))
            {
                backgroundOverlay = map.Overlays[thinkGeoCloudMapsOverlayName] as ThinkGeoCloudMapsOverlay;
            }
            else
            {
                backgroundOverlay = new ThinkGeoCloudMapsOverlay();
                map.Overlays.Insert(0, backgroundOverlay);
            }

            backgroundOverlay.IsVisible = true;
            switch (message.MenuItem.Action.ToLowerInvariant())
            {
                case "light":
                    backgroundOverlay.MapType = ThinkGeoCloudMapsMapType.Light;
                    break;

                case "aerial":
                    backgroundOverlay.MapType = ThinkGeoCloudMapsMapType.Aerial;
                    break;

                case "hybrid":
                    backgroundOverlay.MapType = ThinkGeoCloudMapsMapType.Hybrid;
                    break;

                case "none":
                    backgroundOverlay.IsVisible = false;
                    break;
            }

            map.Refresh(backgroundOverlay);
        }

        public override string[] Actions
        {
            get { return new[] { "light", "aerial", "hybrid", "none" }; }
        }
    }
}