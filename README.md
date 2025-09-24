# MinBibliotek

MinBibliotek är ett konsolbaserat bibliotekssystem utvecklat i C# (.NET 8) där användare kan hantera böcker, söka, låna, lämna tillbaka och administrera biblioteket. Systemet använder en JSON-fil (`books.json`) för att spara och läsa bokdata.

---

## Funktioner

- **Inloggning:** Tre fördefinierade användare med olika roller.
- **Lägg till bok:** Lägg till nya böcker med ISBN, titel och författare.
- **Ta bort bok:** Ta bort böcker baserat på ISBN.
- **Låna bok:** Markera en bok som utlånad.
- **Lämna tillbaka bok:** Markera en bok som tillgänglig igen.
- **Sök böcker:** Sök efter böcker via titel eller författare.
- **Visa alla böcker:** Lista alla böcker med status (Tillgänglig/Utlånad).
- **Filhantering:** Böcker sparas automatiskt till och laddas från `books.json`.
- **Roller:** Stöd för olika användarroller (Admin, Librarian, Borrower).

---

## Inloggning

Vid start möts du av en inloggningsmeny. Använd följande användarnamn och lösenord:

| Roll       | Användarnamn | Lösenord      |
|------------|--------------|---------------|
| Admin      | admin        | admin123      |
| Librarian  | librarian    | librarian123  |
| Borrower   | borrower     | borrower123   |

---

## Roller och deras menyer

### Admin
- Lägg till bok
- Ta bort bok
- Sök böcker
- Visa alla böcker
- Avsluta (logga ut)

### Librarian
- Lägg till bok
- Sök böcker
- Visa alla böcker
- Avsluta (logga ut)

### Borrower
- Låna bok
- Lämna tillbaka bok
- Sök böcker
- Visa alla böcker
- Avsluta (logga ut)

---

## Så använder du programmet

1. **Starta programmet**  
   Kör projektet i Visual Studio eller via terminalen.

2. **Logga in**  
   Ange användarnamn och lösenord enligt tabellen ovan.

3. **Navigera i menyn**  
   Välj alternativ genom att skriva in siffran för önskat val och tryck Enter.

4. **Utför åtgärder**  
   Följ instruktionerna i konsolen för att lägga till, ta bort, låna, söka eller visa böcker.

5. **Logga ut**  
   Välj "Avsluta" i menyn för att logga ut och återgå till startsidan.

---

## Filhantering

- Bokdata sparas i `books.json` i projektets bin-mapp (`bin/Debug/net8.0/`).
- Om filen saknas skapas en ny tom lista vid programstart.

---

## Kodstruktur

- `Book.cs` – Hanterar bokobjekt och boklistan.
- `FileManager.cs` – Sköter sparande och laddning av böcker till/från fil.
- `SearchBook.cs` – Sökfunktion för böcker.
- `Validering.cs` – Validerar användarinmatning.
- `Admin.cs`, `Librarian.cs`, `Borrower.cs`, `User.cs` – Roller och behörigheter.
- `LoggaIn.cs` – Inloggning och rollhantering.
- `Program.cs` – Startpunkt och menyhantering.

---


---

## Installation

1. Klona repot:
2. Öppna projektet i Visual Studio 2022.
3. Bygg och kör projektet.

---

## Licens

MIT

---

Senast uppdaterad: 2025-09-24
