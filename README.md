# Nautical Charts Viewer Sample for Wpf

### Description
Today’s project is a tool of ENC Viewer for displaying unencrypted Electronic Navigational Charts (ENCs) available in the S-57 exchange format (*.000). 
This tool takes use of Map Suite HydrographyExtension to display ENC data in compliance with the latest version of ECDIS Presentation Library Edition 4.0, which is defined by the International Hydrographic Organization (IHO) in the special publication S-52. 

NOTE: the styling file “NauticalCharts.xml” for drawing S-57 (*.000) file is included in the source code package.

Please refer to [Wiki](http://wiki.thinkgeo.com/wiki/map_suite_desktop_for_wpf) for the details.

![Screenshot](https://github.com/ThinkGeo/NauticalChartsViewerSample-ForWpf/blob/master/Screenshot.png)

### Requirements
This sample makes use of the following NuGet Packages

[MapSuite 10.0.0](https://www.nuget.org/packages?q=ThinkGeo)

### About the Code
```csharp
private void DrawPivot(Vertex pivotVertex, MappingConverter converter)
{
    Color fillColor = Color.Red;
    Color outLineColor = Color.DarkBlue;
    SolidBrush brush = new SolidBrush(fillColor);
    Pen pen = new Pen(outLineColor, 2);

    PointF point = converter.GetMappingPoint(pivotVertex);
    Vertex rightMostVertex = new Vertex(pivotVertex.X + 10, pivotVertex.Y);
    float radius = 5f;

    graphics.FillEllipse(brush, point.X - radius, point.Y - radius, radius * 2, radius * 2);
    graphics.DrawEllipse(pen, point.X - radius, point.Y - radius, radius * 2, radius * 2);
}
```
### Getting Help

[Map Suite Desktop for Wpf Wiki Resources](http://wiki.thinkgeo.com/wiki/map_suite_desktop_for_wpf)

[Map Suite Desktop for Wpf Product Description](https://thinkgeo.com/ui-controls#desktop-platforms)

[ThinkGeo Community Site](http://community.thinkgeo.com/)

[ThinkGeo Web Site](http://www.thinkgeo.com)

### Key APIs
This example makes use of the following APIs:

- [ThinkGeo.MapSuite.Shapes.Vertex](http://wiki.thinkgeo.com/wiki/api/thinkgeo.mapsuite.shapes.vertex)

### About Map Suite
Map Suite is a set of powerful development components and services for the .Net Framework.

### About ThinkGeo
ThinkGeo is a GIS (Geographic Information Systems) company founded in 2004 and located in Frisco, TX. Our clients are in more than 40 industries including agriculture, energy, transportation, government, engineering, software development, and defense.
