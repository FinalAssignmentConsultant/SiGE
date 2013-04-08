Module GE

    Private Function GenerateKML(ByVal lat As Double, ByVal lon As Double) As String
        'Dim xDoc As New System.Xml.XmlDocument
        ''Change this url to where you saved your base XML doc
        'xDoc.Load("http://www.timhibbard.com/kml/base.xml")

        'Dim nowticks As String = Now.Ticks.ToString
        ''creates a new unique name to save
        'Dim tmpFileName As String = Server.MapPath("kml\") & nowticks & ".xml"

        ''replaces the longitude tag with the lon parameter
        'Dim MyNode As System.Xml.XmlNodeList = xDoc.GetElementsByTagName("longitude")
        'MyNode.Item(0).InnerText = lon.ToString

        ''replaces the latitude tag with the lon parameter
        'MyNode = xDoc.GetElementsByTagName("latitude")
        'MyNode.Item(0).InnerText = lat.ToString

        ''replaces the coordinates tag with actual data
        'MyNode = xDoc.GetElementsByTagName("coordinates")
        'MyNode.Item(0).InnerText = lon.ToString & ", " & lat.ToString & ", 0"

        ''saves the file as an XML document
        'xDoc.Save(tmpFileName)
        'Dim actualFileName As String = tmp.TrimEnd(".xml".ToCharArray) & ".kml"
        ''renames the file as a KML file that Google Earth can understand
        'Rename(tmpFileName, actualFileName)

        'Return "http://www.timhibbard.com/kml/" & nowticks & ".kml"
        Return Nothing
    End Function
End Module
