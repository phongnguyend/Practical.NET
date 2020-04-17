## REST API

### Using CURL
```powershell
curl -i -u username:password -H "content-type:application/json" -XPUT -d "{""durable"":true}" http://localhost:15672/api/queues/%2f/QUEUE_NAME
curl -i -u username:password -H "content-type:application/json" -XPUT -d"{""type"":""direct"",""durable"":true}" http://localhost:15672/api/exchanges/%2f/EXCHANGE_NAME
curl -i -u username:password -H "content-type:application/json" -XPOST -d"{""routing_key"":""routing_key"",""arguments"":{}}" http://localhost:15672/api/bindings/%2f/e/EXCHANGE_NAME/q/QUEUE_NAME
```

### Using Powershell v5
```powershell
$userpass  = "username" + ":" + "password"
$bytes= [System.Text.Encoding]::UTF8.GetBytes($userpass)
$encodedlogin=[Convert]::ToBase64String($bytes)
$authheader = "Basic " + $encodedlogin
$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("Authorization",$authheader)
$headers.Add("Accept","application/json")
$headers.Add("Content-Type","application/json")
$uri = "http://localhost:15672/api/queues/%2f/QUEUE_NAME"
$jsonbody = "{""durable"":true}"
$response = Invoke-RestMethod -Uri $uri -Headers $headers -Method Put -ContentType "application/json" -Body $jsonbody
```

### Using Powershell v4
```powershell
function fixuri($uri){
  $UnEscapeDotsAndSlashes = 0x2000000;
  $SimpleUserSyntax = 0x20000;

  $type = $uri.GetType();
  $fieldInfo = $type.GetField("m_Syntax", ([System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::NonPublic));

  $uriParser = $fieldInfo.GetValue($uri);
  $typeUriParser = $uriParser.GetType().BaseType;
$fieldInfo = $typeUriParser.GetField("m_Flags", ([System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::NonPublic -bor [System.Reflection.BindingFlags]::FlattenHierarchy));
$uriSyntaxFlags = $fieldInfo.GetValue($uriParser);

$uriSyntaxFlags = $uriSyntaxFlags -band (-bnot $UnEscapeDotsAndSlashes);
$uriSyntaxFlags = $uriSyntaxFlags -band (-bnot $SimpleUserSyntax);
$fieldInfo.SetValue($uriParser, $uriSyntaxFlags);
}

$userpass  = "username" + ":" + "password"
$bytes= [System.Text.Encoding]::UTF8.GetBytes($userpass)
$encodedlogin=[Convert]::ToBase64String($bytes)
$authheader = "Basic " + $encodedlogin
$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("Authorization", $authheader)
$uri = New-Object System.Uri -ArgumentList ("http://localhost:15672/api/queues/%2f/QUEUE_NAME")
fixuri $uri
$jsonbody = "{""durable"":true}"
$response = Invoke-RestMethod -Uri $uri -Headers $headers -Method Put -ContentType "application/json" -Body $jsonbody
```
