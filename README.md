# Silverlight Multilingual Data Fixer

*Admin tool to **detect and fix missing translations** in dynamic multilingual content*

---

## About

This **Silverlight web application** helps administrators **identify and correct untranslated or missing dynamic content** across multiple languages in a database-driven system.

> Built using **Silverlight + C# + SQL Server**  
> Designed for **enterprise content management systems** with multilingual support.

---

## Purpose

Many systems display **dynamic data** (e.g., product names, categories, user inputs) in multiple languages.  
When translations are missing, fallback text or blank values appear.

This tool:
- Scans database for **missing translations**
- Highlights **untranslated dynamic fields**
- Allows **in-place editing and saving** of translations
- Ensures **consistent multilingual UX**

---

## Tech Stack

| Layer       | Technology              |
|-------------|-------------------------|
| **UI**      | Silverlight (XAML + C#) |
| **Backend** | C#, ADO.NET             |
| **Database**| SQL Server              |
| **Host**    | ASP.NET Web Forms       |

---

## Key Features

- **Scan Mode**: Detect missing translations by language
- **Grid View**: List all untranslated records
- **Inline Edit**: Fix translations directly in UI
- **Bulk Save**: Commit changes to database
- **Language Switcher**: Compare across locales
- **Audit Log**: Track who fixed what

---

## How to Use

1. Launch the Silverlight app in browser
2. Select **Source Language** and **Target Language**
3. Click **"Scan for Missing Translations"**
4. Edit missing values in the grid
5. Click **"Save All"** to update database

---

## Setup (Legacy Silverlight App)

> Requires: **IIS + Silverlight Plugin + SQL Server**

```bash
1. Deploy .xap file to web server
2. Configure connection string in web.config
3. Ensure Silverlight plugin is enabled in browser
4. Access via http://yoursite.com/ClientBin/App.xap
