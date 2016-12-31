Imports System.Xml

Public Class InvItemDB
    Private Const Path As String = "..\..\InventoryItems.xml"

    Public Shared Function GetItems() As List(Of InvItem)
        ' create the list
        Dim items As New List(Of InvItem)

        ' create the XmlReaderSettings object
        Dim settings As New XmlReaderSettings
        settings.IgnoreWhitespace = True
        settings.IgnoreComments = True

        ' create the XmlReader object
        Dim xmlIn As XmlReader = XmlReader.Create(Path, settings)

        ' read past all nodes to the first Book node
        If xmlIn.ReadToDescendant("Item") Then
            ' create one InvItem object for each Item node
            Do
                Dim item As New InvItem
                xmlIn.ReadStartElement("Item")
                item.ItemNo = xmlIn.ReadElementContentAsInt
                item.Description = xmlIn.ReadElementContentAsString
                item.Price = xmlIn.ReadElementContentAsDecimal
                items.Add(item)
            Loop While xmlIn.ReadToNextSibling("Item")
        End If

        ' close the XmlReader object
        xmlIn.Close()

        Return items
    End Function

    Public Shared Sub SaveItems(items As List(Of InvItem))
        ' create the XmlWriterSettings object
        Dim settings As New XmlWriterSettings
        settings.Indent = True
        settings.IndentChars = ("    ")

        ' create the XmlWriter object
        Dim xmlOut As XmlWriter = XmlWriter.Create(Path, settings)

        ' write the start of the document
        xmlOut.WriteStartDocument()
        xmlOut.WriteStartElement("Items")

        ' write each InvItem object to the xml file
        For Each item As InvItem In items
            xmlOut.WriteStartElement("Item")
            xmlOut.WriteElementString("ItemNo", item.ItemNo.ToString)
            xmlOut.WriteElementString("Description", item.Description)
            xmlOut.WriteElementString("Price", item.Price.ToString)
            xmlOut.WriteEndElement()
        Next item

        ' write the end tag for the root element
        xmlOut.WriteEndElement()

        ' close the xmlWriter object
        xmlOut.Close()
    End Sub
End Class
