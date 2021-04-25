function keyClick() {
    var na = document.getElementById("int1").value;
    var nb = document.getElementById("int2").value;
    var data = '<?xml version="1.0" encoding="utf-8"?>';
    data = data + '<soap12:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap12="http://www.w3.org/2003/05/soap-envelope">';
    data = data + '<soap12:Body>';
    data = data + '<RunActionDirect xmlns="http://www.starlims.com/webservices/">';
    data = data + '<actionID>LIMIT.test01</actionID>';
    data = data + '<parameters>';
    data = data + ' <anyType xsi:type="xsd:int">'+na+'</anyType>';
    data = data + ' <anyType xsi:type="xsd:int">'+nb+'</anyType>';
    data = data + '</parameters>';
    data = data + '<UserName>0675.YANJ</UserName>';
    data = data + '<Password>Sep675</Password>';
    data = data + '</RunActionDirect>';
    data = data + '</soap12:Body>';
    data = data + '</soap12:Envelope>';
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.open("POST", "http://sh.seplims.com/STARLIMS10.SHH/services/generic.asmx", false);
    xmlhttp.setRequestHeader("Content-Type", "application/soap+xml; charset=utf-8");
    xmlhttp.send(data);
    var nodeList = xmlhttp.responseXML.documentElement.getElementsByTagName("anyType");
    for(var i=0;i<nodeList.length;i++){
       console.log(nodeList[i].textContent)
      }
   

   
}
