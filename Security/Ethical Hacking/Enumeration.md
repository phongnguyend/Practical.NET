# Enumeration
- Defaults & NetBIOS (Network Basic Input/Output System)
  + Change it
  + Be aware of your ports
  + Turn off SMB
- SNMP (Simple Network Management Protocol)
  + Turn it off
  + Upgrade to v3
  + Group policy: "additional restrictions for anonymous connections"
  + Block ports 161 on TCP/UDP
  + IPSec filtering
  + Limit access to null sessions
- LDAP (Lightweight Directory Access Protocol)
  + Separate email address and logon names
  + Use SSL to encrypt LDAP
  + Encrypt drives that store LDAP databases
- NTP (Network Time Protocol)
  + Watch your ports
  + Understand what software is installed
  + Check your master NTP
- SMTP (Simple Mail Transfer Protocol)
  + Disable open relays
  + Drop unknown recipients
  + Never include email server info in your email or posts
- DNS (Domain Name System)
  + Configure DNS Zone Transfer to explicit servers
  + Ensure that nonpublic hostnames are not referenced to IP with the DNS Zone files or publicly accessible DNS servers
  + Check both internal and external DNS servers
  + Ensure that HINFO and other records do not appear in DNS zone files
- IPSec (Internet Protocol Security)
  + nmap -sU -p 500 <targetIP>
  + ike-scan -M <targetIP>
- VoIP (Voice over Internet Protocol)
  + SIP (Session Initiation Protocol)
  + SIPVicious
  + Svmap
- RPC (Remote Procedure Call)
  + nmap -sR 192.168.0.1-254
