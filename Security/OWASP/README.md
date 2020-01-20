## OWASP
- [OWASP Top Ten Project](https://www.owasp.org/index.php/Category:OWASP_Top_Ten_Project)
- [Source Code Analysis Tools](https://www.owasp.org/index.php/Source_Code_Analysis_Tools)
- [OWASP .NET Project](https://www.owasp.org/index.php/Category:OWASP_.NET_Project)
- [.Net Security Cheat Sheet](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/DotNet_Security_Cheat_Sheet.md)

## OWASP [Top 10 2010](https://www.owasp.org/index.php/Top_10_2010)

- A1: [Injection](https://www.owasp.org/index.php/Top_10_2010-A1-Injection)
- A2: [Cross-Site Scripting (XSS)](https://www.owasp.org/index.php/Top_10_2010-A2-Cross-Site_Scripting_(XSS))
- A3: [Broken Authentication and Session Management](https://www.owasp.org/index.php/Top_10_2010-A3-Broken_Authentication_and_Session_Management)
- A4: [Insecure Direct Object References](https://www.owasp.org/index.php/Top_10_2010-A4-Insecure_Direct_Object_References)
- A5: [Cross-Site Request Forgery (CSRF)](https://www.owasp.org/index.php/Top_10_2010-A5-Cross-Site_Request_Forgery_(CSRF))
- A6: [Security Misconfiguration](https://www.owasp.org/index.php/Top_10_2010-A6-Security_Misconfiguration)
- A7: [Insecure Cryptographic Storage](https://www.owasp.org/index.php/Top_10_2010-A7-Insecure_Cryptographic_Storage)
- A8: [Failure to Restrict URL Access](https://www.owasp.org/index.php/Top_10_2010-A8-Failure_to_Restrict_URL_Access)
- A9: [Insufficient Transport Layer Protection](https://www.owasp.org/index.php/Top_10_2010-A9-Insufficient_Transport_Layer_Protection)
- A10: [Unvalidated Redirects and Forwards](https://www.owasp.org/index.php/Top_10_2010-A10-Unvalidated_Redirects_and_Forwards)

## OWASP [Top 10 2013](https://www.owasp.org/index.php/Top_10_2013)

- A1: [Injection](https://www.owasp.org/index.php/Top_10_2013-A1-Injection)
- A2: [Broken Authentication and Session Management](https://www.owasp.org/index.php/Top_10_2013-A2-Broken_Authentication_and_Session_Management)
- A3: [Cross-Site Scripting (XSS)](https://www.owasp.org/index.php/Top_10_2013-A3-Cross-Site_Scripting_(XSS))
- A4: [Insecure Direct Object References](https://www.owasp.org/index.php/Top_10_2013-A4-Insecure_Direct_Object_References)
- A5: [Security Misconfiguration](https://www.owasp.org/index.php/Top_10_2013-A5-Security_Misconfiguration)
- A6: [Sensitive Data Exposure](https://www.owasp.org/index.php/Top_10_2013-A6-Sensitive_Data_Exposure)
- A7: [Missing Function Level Access Control](https://www.owasp.org/index.php/Top_10_2013-A7-Missing_Function_Level_Access_Control)
- A8: [Cross-Site Request Forgery (CSRF)](https://www.owasp.org/index.php/Top_10_2013-A8-Cross-Site_Request_Forgery_(CSRF))
- A9: [Using Components with Known Vulnerabilities](https://www.owasp.org/index.php/Top_10_2013-A9-Using_Components_with_Known_Vulnerabilities)
- A10: [Unvalidated Redirects and Forwards](https://www.owasp.org/index.php/Top_10_2013-A10-Unvalidated_Redirects_and_Forwards)

## OWASP [Top 10 2017](https://www.owasp.org/index.php/Top_10-2017_Top_10)

- A1: [Injection](https://www.owasp.org/index.php/Top_10-2017_A1-Injection)
- A2: [Broken Authentication](https://www.owasp.org/index.php/Top_10-2017_A2-Broken_Authentication)
- A3: [Sensitive Data Exposure](https://www.owasp.org/index.php/Top_10-2017_A3-Sensitive_Data_Exposure)
  + Keep sensitive data out of the URL
    + Web browsers cache the URL history
    + Referer header
  + [OWASP Cheat Sheet: Transport Layer Protection](https://cheatsheetseries.owasp.org/cheatsheets/Transport_Layer_Protection_Cheat_Sheet.html)
    + Never use SSL 1,2 or 3
    + Should only support TLS 1.2 and TLS 1.3
    + Only Support Strong Ciphers
  + [OWASP Cheat Sheet: HTTP Strict Transport Security (HSTS)](https://cheatsheetseries.owasp.org/cheatsheets/HTTP_Strict_Transport_Security_Cheat_Sheet.html)
  + [OWASP Cheat Sheet: Password Storage](https://www.owasp.org/index.php/Password_Storage_Cheat_Sheet)
  + [OWASP Cheat Sheet: Cryptographic Storage](https://www.owasp.org/index.php/Cryptographic_Storage_Cheat_Sheet)
  + [OWASP Secure Headers Project](https://www.owasp.org/index.php/OWASP_Secure_Headers_Project)
- A4: [XML External Entities (XXE)](https://www.owasp.org/index.php/Top_10-2017_A4-XML_External_Entities_(XXE))
  + [XML External Entity Prevention · OWASP Cheat Sheet Series](https://cheatsheetseries.owasp.org/cheatsheets/XML_External_Entity_Prevention_Cheat_Sheet.html#net)
- A5: [Broken Access Control](https://www.owasp.org/index.php/Top_10-2017_A5-Broken_Access_Control)
- A6: [Security Misconfiguration](https://www.owasp.org/index.php/Top_10-2017_A6-Security_Misconfiguration)
- A7: [Cross-Site Scripting (XSS)](https://www.owasp.org/index.php/Top_10-2017_A7-Cross-Site_Scripting_(XSS))
- A8: [Insecure Deserialization](https://www.owasp.org/index.php/Top_10-2017_A8-Insecure_Deserialization)
  + [Deserialization · OWASP Cheat Sheet Series](https://cheatsheetseries.owasp.org/cheatsheets/Deserialization_Cheat_Sheet.html#net-csharp)
- A9: [Using Components with Known Vulnerabilities](https://www.owasp.org/index.php/Top_10-2017_A9-Using_Components_with_Known_Vulnerabilities)
  + [OWASP Dependency Check](https://www.owasp.org/index.php/OWASP_Dependency_Check)
    + [GitHub](https://github.com/jeremylong/DependencyCheck)
  + [OWASP Dependency Track](https://www.owasp.org/index.php/OWASP_Dependency_Track_Project)
    + [Home](https://dependencytrack.org/)
    + [GitHub](https://github.com/DependencyTrack/dependency-track)
  + [OWASP SafeNuGet](https://github.com/OWASP/SafeNuGet)
  + [CVE - Common Vulnerabilities and Exposures (CVE)](https://cve.mitre.org/)
  + [National Vulnerability Database](https://nvd.nist.gov/)
  + [Open Bug Bounty](https://www.openbugbounty.org/)
  + [Virtual Patching Best Practices](https://www.owasp.org/index.php/Virtual_Patching_Best_Practices)
  + [Retire.js](https://retirejs.github.io/retire.js/)
  + [npm audit](https://docs.npmjs.com/cli/audit)
- A10: [Insufficient Logging & Monitoring](https://www.owasp.org/index.php/Top_10-2017_A10-Insufficient_Logging%26Monitoring)
  + [Logging · OWASP Cheat Sheet Series](https://cheatsheetseries.owasp.org/cheatsheets/Logging_Cheat_Sheet.html)

## Security Announcements:
- [.NET Core Security Announcements](https://github.com/dotnet/announcements/issues?q=is%3Aopen+is%3Aissue+label%3ASecurity) 
- [ASP.NET Core & Entity Framework Core Security Announcements](https://github.com/aspnet/Announcements/issues?q=is%3Aopen+is%3Aissue+label%3ASecurity) 
