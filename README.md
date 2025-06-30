|[![VirusTotal Scan](https://img.shields.io/badge/VirusTotal-Scan-blue?logo=virustotal)](https://www.virustotal.com/gui/url/6bac4a1d481dd693981dae086db82e5cde8b727f5c6cf462167b4df9ba19ca4f?nocache=1)|SysAnalyzer.Gui – Systemanalyse-Tool|
|---|---|

## Beschreibung
**SysAnalyzer.Gui** ist ein Windows-basierendes Systemanalyse-Tool mit einer modernen WPF-Benutzeroberfläche. Es bietet eine übersichtliche Darstellung zentraler Systeminformationen wie Computername, Betriebssystem, CPU-Details sowie eine Liste der Top 10 laufenden Prozesse mit RAM-Auslastung. Das Tool ist speziell für Administratoren und Entwickler konzipiert, die eine schnelle und visuelle Analyse ihrer Systeme benötigen.

---

## Features

- Anzeige von grundlegenden Systeminformationen (Computername, OS, CPU)
- Übersicht der Top 10 laufenden Prozesse nach Arbeitsspeicherverbrauch
- Benutzerfreundliche WPF-GUI mit übersichtlicher Struktur
- Basierend auf .NET 8.0 für moderne Windows-Umgebungen
- Erweiterbar für weitere Systeminformationen (RAM, Laufwerke, Netzwerk)

---

## Systemanforderungen

- Windows 10 oder höher
- .NET 8.0 SDK und Laufzeit ([https://dotnet.microsoft.com/en-us/download/dotnet/8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0))
- Visual Studio 2022 oder höher empfohlen für Entwicklung und Kompilierung

---

## Installation und Ausführung

1. **Projekt herunterladen**  
   Entpacken Sie das bereitgestellte ZIP-Archiv `SysAnalyzer.Gui_net8_with_copyright.zip` in einen beliebigen Ordner.

2. **.NET 8.0 SDK installieren**  
   Falls noch nicht installiert, laden Sie das .NET 8.0 SDK von der offiziellen Microsoft-Seite herunter und installieren Sie es:  
   ```powershell
   https://dotnet.microsoft.com/en-us/download/dotnet/8.0
Projekt öffnen (optional)
Öffnen Sie die Projektmappe SysAnalyzer.Gui.csproj in Visual Studio 2022 (oder höher) oder einem anderen kompatiblen Editor.

Abhängigkeiten wiederherstellen
Öffnen Sie eine PowerShell oder Eingabeaufforderung im Projektordner und führen Sie aus:

```yarn
dotnet restore
```

### 3. Projekt öffnen (optional)  
Öffnen Sie die Projektmappe `SysAnalyzer.Gui.csproj` in Visual Studio 2022 (oder höher) oder einem anderen kompatiblen Editor.

### 4. Abhängigkeiten wiederherstellen  
Öffnen Sie eine PowerShell oder Eingabeaufforderung im Projektordner und führen Sie aus:  

```powershell
dotnet restore
```

5. Projekt bauen und starten
Starten Sie die Anwendung mit:

```yarn
dotnet run
```
