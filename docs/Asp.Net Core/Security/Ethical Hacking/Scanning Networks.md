# Scanning Networks
- TCP Communications
- UDP Communications
- TCP Header Flags
- TCP 3-Way Handshake
- Scanning Tools:
  + Angry IP
  + Nmap/Zenmap
  + hping3
  + Firewalk
  + Fing - Network Tools (Adroid)
- Types of Scanning:
  + Full Scans
  + Half-open Scans
  + Xmas Scans
  + FIN Scans
  + NULL Scans
  + UDP Scans
  + Evading IDS Systems with Idle Scans
  + Listing and SSDP (Simple Service Discovery Protocol) Scanning
- Countermeasures:
  + Firewalls configured to look for SYN Scans
  + IDS (Intrusion Detection System) should dectect Nmap/Snort
  + Open only require ports
  + Filter ICMP messages
  + Test your own network
  + Keep firewalls/ IDS updated/patched
- IDS Evasion Methods:
  + Spoof your IP and sniff the responses (nmap -D, nmap -sI)
  + Use a proxy or pwned machine
  + Fragment IP Packets (nmap -f)
  + If you're able, use source routing
- OS Fingerprinting:
  + nmap -O
- Banner Grabbing: information is leaked by default messages
  + telnet
  + netcap
- OS Fingerprinting & Banner Grabbing Countermeasures:
  + Misdirection/ fake banners
  + IIS lockdown tool
  + ServerMask
  + Turn off unused services
  + Change the ServerSignature (httpd.conf, httpd.config: mod_headers)
