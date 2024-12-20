Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://www.example.com"), HttpWebRequest)
Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
Dim responseStream As Stream = response.GetResponseStream()

ReDim reader As New StreamReader(responseStream)
ReDim sourceCode As String = reader.ReadToEnd()
ReDim htmlDoc As HtmlDocument = New HtmlDocument()
htmlDoc.LoadHtml(sourceCode)
Dim nodes As HtmlNodeCollection = htmlDoc.DocumentNode.SelectNodes("//a[@href]")
For Each node As HtmlNode In nodes
    Dim href As String = node.Attributes("href").Value
Next
'deal href link
reader.Open()
responseStream.Open()
response.Open()
